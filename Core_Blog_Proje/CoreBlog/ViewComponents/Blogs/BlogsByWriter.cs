using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blogs
{
    public class BlogsByWriter:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = bm.GetBlogByWriter(id).Where(x => x.BlogStatus == true).OrderByDescending(x => x.BlogID).Take(3).ToList();
            return View(values);

        }
    }
}
