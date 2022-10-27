using CoreBlog.Areas.Admin.Models;
using CoreBlog.Models;
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
    public class AdminSettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        AddImageFile addImage = new AddImageFile();

        public AdminSettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Setting()
        {
            var current_admin = await _userManager.FindByNameAsync(User.Identity.Name);
            AdminEditViewModel model = new AdminEditViewModel();
            model.ID = current_admin.Id;
            model.nameSurname = current_admin.NameSurname;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Setting(AdminEditViewModel p)
        {
            var current_admin = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                current_admin.NameSurname = p.nameSurname;
                if (p.Image != null)
                    current_admin.ImageUrl = addImage.ImageAdd(p.Image);
                if (p.passwordChange == true)
                    current_admin.PasswordHash = _userManager.PasswordHasher.HashPassword(current_admin, p.password);
                var result = await _userManager.UpdateAsync(current_admin);
                if (result.Succeeded)
                    return RedirectToAction("LogOut", "AdminLogin");
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}