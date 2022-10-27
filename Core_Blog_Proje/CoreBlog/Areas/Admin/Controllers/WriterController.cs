using BusinessLayer.Concrete;
using CoreBlog.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class WriterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult WriterPage()
        {
            return View();
        }

        public async Task<IActionResult> WriterList()
        {
            var writers = await _userManager.GetUsersInRoleAsync("Writer");
            var jsonwriters = JsonConvert.SerializeObject(writers);
            return Json(jsonwriters);
        }

        public async Task<IActionResult> ChangeWriterStatus(int id)
        {
            var writer = await _userManager.FindByIdAsync(id.ToString());
            if (writer.Status == true)
            {
                writer.Status = false;
                await _userManager.UpdateAsync(writer);
                TempData["PasifBasari"] = "Yazar başarıyla pasif hale getirildi";
            }
            else
            {
                writer.Status = true;
                await _userManager.UpdateAsync(writer);
                TempData["AktifBasari"] = "Yazar başarıyla aktif hale getirildi";
            }
            return RedirectToAction("WriterPage", "Writer");
        }
    }
}
