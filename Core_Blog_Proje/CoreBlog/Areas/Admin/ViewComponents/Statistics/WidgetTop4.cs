using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistics
{
    public class WidgetTop4 : ViewComponent
    {
        Context c = new Context();

        private readonly UserManager<AppUser> _userManager;

        public WidgetTop4(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var admin = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.gelen_mesaj_sayi = c.Messages.Where(x => x.ReceiverId == admin.Id).Count();
            ViewBag.notf_say = c.Notifications.Count();
            ViewBag.topla_kullanici = c.Users.Count();            
            return View(admin);
        }
    }
}
