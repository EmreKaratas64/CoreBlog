using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blogs
{
    public class DasboardBlogPhotos : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogDal());

        private readonly UserManager<AppUser> _userManager;

        public DasboardBlogPhotos(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.namesurname = currentWriter.NameSurname;
            var last4blogphoto = bm.TGetList().OrderByDescending(x => x.BlogID).Take(4).ToList();
            return View(last4blogphoto);
        }
    }
}
