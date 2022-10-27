using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blogs
{
    public class DashboardBlogList : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke()
        {
            var last5blog = bm.GetBlogListWithCategory().OrderByDescending(x => x.BlogID).Take(5).ToList();
            return View(last5blog);
        }

    }
}
