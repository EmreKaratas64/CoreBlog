using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [Authorize(Roles ="Writer")]
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());

        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> InBox()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            int id = currentWriter.Id;
            var values = mm.GetMessageInBox(id);
            return View(values);
        }

        public async Task<IActionResult> SendBox()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            int id = currentWriter.Id;
            var values = mm.GetMessageSendBox(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var message = mm.TGetById(id);
            return View(message);
        }

        public IActionResult MarkAsRead(int id)
        {
            var message = mm.TGetById(id);
            if (message.MessageStatus != true)
            {
                message.MessageStatus = true;
                mm.TUpdate(message);
            }
            return RedirectToAction("InBox", "Message");
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageViewModel p)
        {
            var currentwriter = await _userManager.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid)
            {
                var receiverwriter = await _userManager.FindByEmailAsync(p.AlıcıMail);
                if(receiverwriter == null)
                {
                    ViewBag.usernotfound = "Kullanıcı bulunamadı, lütfen alıcı mail adresini kontrol ediniz!";
                    return View();
                }
                Message message = new Message()
                {
                    Subject = p.Subject,
                    MessageDate = DateTime.Now,
                    MessageStatus = true,
                    ReceiverId = receiverwriter.Id,
                    SenderId = currentwriter.Id,
                    MessageDetails = p.MessageDetails
                };
                mm.TAdd(message);
                return RedirectToAction("SendBox", "Message");
            }
            return View(p);

        }
    }
}
