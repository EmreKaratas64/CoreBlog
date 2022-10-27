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
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> UsersPage()
        {
            var users = await _userManager.GetUsersInRoleAsync("User");
            return View(users);
        }

        public async Task<IActionResult> ChangeUserStatus(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user.Status == true)
            {
                user.Status = false;
                await _userManager.UpdateAsync(user);
                TempData["PasifBasari"] = "Kullanıcı başarıyla pasif hale getirildi";
            }
            else
            {
                user.Status = true;
                await _userManager.UpdateAsync(user);
                TempData["AktifBasari"] = "Kullanıcı başarıyla aktif hale getirildi";
            }
            return RedirectToAction("UsersPage", "User");
        }
    }
}
