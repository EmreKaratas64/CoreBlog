using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class AdminMessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        MessageManager messageManager = new MessageManager(new EfMessageDal());


        public AdminMessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> InBox()
        {
            var currentAdmin = await _userManager.FindByNameAsync(User.Identity.Name);
            var mesajlar = messageManager.GetMessageInBox(currentAdmin.Id);
            ViewBag.gelen_mesaj = messageManager.GetMessageInBox(currentAdmin.Id).Count();
            return View(mesajlar);
        }

        public async Task<IActionResult> SendBox()
        {
            var currentAdmin = await _userManager.FindByNameAsync(User.Identity.Name);
            var mesajlar = messageManager.GetMessageSendBox(currentAdmin.Id);
            ViewBag.giden_mesaj = messageManager.GetMessageSendBox(currentAdmin.Id).Count();
            return View(mesajlar);
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage(int? id)
        {
            if (id != null)
            {
                var constructor = await _userManager.FindByIdAsync(id.GetValueOrDefault().ToString());
                if (constructor != null)
                {
                    ViewBag.receivermail = constructor.Email;
                }
                else
                {
                    var message = messageManager.TGetById(id.GetValueOrDefault());
                    var senderuser = await _userManager.FindByIdAsync(message.SenderId.ToString());
                    ViewBag.receivermail = senderuser.Email;
                }

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageViewModel p)
        {
            var currentAdmin = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                var receivercontrol = await _userManager.FindByEmailAsync(p.AlıcıMail);
                if (receivercontrol == null)
                {
                    ViewBag.usernotfoundadmin = "Kullanıcı bulunamadı, lütfen alıcı mail adresini kontrol ediniz!";
                    return View();
                }

                Message message = new Message()
                {
                    Subject = p.Subject,
                    MessageDetails = p.MessageDetails,
                    MessageDate = DateTime.Now,
                    MessageStatus = true,
                    SenderId = currentAdmin.Id,
                    ReceiverId = receivercontrol.Id
                };
                messageManager.TAdd(message);
                return RedirectToAction("SendBox", "AdminMessage");
            }

            return View(p);
        }


        public IActionResult DeleteInBoxMessage(int id)
        {
            var message = messageManager.TGetById(id);
            messageManager.TDelete(message);
            TempData["InBoxdeletesuccess"] = "Mesaj başarıyla silindi";
            return RedirectToAction("InBox", "AdminMessage");
        }

        public IActionResult DeleteSendBoxMessage(int id)
        {
            var message = messageManager.TGetById(id);
            messageManager.TDelete(message);
            TempData["SendBoxdeletesuccess"] = "Mesaj başarıyla silindi";
            return RedirectToAction("SendBox", "AdminMessage");
        }

        public async Task<IActionResult> MessageDetailInBox(int id)
        {
            var message = messageManager.TGetById(id);
            var senderuser = await _userManager.FindByIdAsync(message.SenderId.ToString());
            ViewBag.sendermail = senderuser.Email;
            return View(message);
        }

        public async Task<IActionResult> MessageDetailSendBox(int id)
        {
            var message = messageManager.TGetById(id);
            var receiveruser = await _userManager.FindByIdAsync(message.ReceiverId.ToString());
            ViewBag.receiverrmail = receiveruser.Email;
            return View(message);
        }

    }
}
