using CoreBlog.Models;
using CoreBlogApi.DataAccessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blogs
{
    public class HomePageWelcomeBack : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public HomePageWelcomeBack(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if(User.Identity.Name != null)
            {
                var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.namesurname = currentUser.NameSurname;
            }
            return View();
        }
    }
}
