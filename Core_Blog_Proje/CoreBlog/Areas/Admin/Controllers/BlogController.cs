using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());

        public IActionResult BlogsPage(int page = 1)
        {
            var blogs = bm.GetBlogListWithCategory().ToPagedList(page, 10); ;
            return View(blogs);
        }
    }
}
