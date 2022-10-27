using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
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
    public class DashboardWriterBlogs : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogDal());

        private readonly UserManager<AppUser> _userManager;

        public DashboardWriterBlogs(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            int writerid = currentWriter.Id;
            var values = bm.GetBlogListWithCategory().Where(x => x.AppUserId == writerid && x.BlogStatus == true).OrderByDescending(x => x.BlogID).Take(4).ToList();
            return View(values);

        }
    }
}
