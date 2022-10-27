using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.AdminSideBar_and_Profile
{
    public class AdminSideBar:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        Context c = new Context();

        public AdminSideBar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentuser = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.admin_name = currentuser.NameSurname;
            ViewBag.admin_photo = currentuser.ImageUrl;
            ViewBag.notification_sayi = c.Notifications.Where(x => x.NotificationStatus == true).Count();
            return View();
        }
    }
}
