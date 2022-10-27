using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [Authorize(Roles ="Writer")]
    public class DashboardController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> DashboardPage()
        {
            CommentManager cm = new CommentManager(new EfCommentDal());
            Context c = new Context();
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            int id = currentWriter.Id;
            ViewBag.toplamblog = c.Blogs.Count().ToString();
            ViewBag.yazarblog = c.Blogs.Where(x => x.AppUserId == id).Count();
            ViewBag.yazaryorumsayi = cm.GetCommentListwithBlog().Where(x=>x.Blog.AppUserId == id).Count();
            return View();
        }
    }
}