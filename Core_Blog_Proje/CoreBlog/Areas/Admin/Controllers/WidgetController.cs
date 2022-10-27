
using DataAccessLayer.Concrete;
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
    public class WidgetController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        Context c = new Context();

        public WidgetController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MainPage()
        {
            var moderator = await _userManager.GetUsersInRoleAsync("Moderator");
            var admin = await _userManager.GetUsersInRoleAsync("Admin");
            var yazarlar = await _userManager.GetUsersInRoleAsync("Writer");
            var constructor = c.UserRoles.Where(x => x.RoleId == 5).FirstOrDefault();
            var site_constructor = await _userManager.FindByIdAsync(constructor.UserId.ToString());
            ViewBag.constructor_name = site_constructor.NameSurname;
            ViewBag.constructor_img = site_constructor.ImageUrl;

            ViewBag.mesajlar = c.Contacts.Count();
            ViewBag.bloglar = c.Blogs.Count();
            ViewBag.yorumlar = c.Comments.Count();
            ViewBag.kategoriler = c.Categories.Count();
            ViewBag.aktif_blog = c.Blogs.Where(x => x.BlogStatus == true).Count();
            ViewBag.aktif_yazar = yazarlar.Where(x => x.Status == true).Count();
            ViewBag.bildirimler = c.Notifications.Count();
            ViewBag.moderatorler = moderator.Count();
            ViewBag.adminler = admin.Count();
            ViewBag.site_const_id = constructor.UserId;
            return View();
        }
    }
}
