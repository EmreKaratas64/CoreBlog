using CoreBlog.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterDashboardSidebarProfile : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public WriterDashboardSidebarProfile(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.namesurname = currentWriter.NameSurname;
            ViewBag.writerphoto = currentWriter.ImageUrl; ;
            return View();
        }
    }
}
