using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blogs
{
    public class Last3Blogs:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.TGetList().OrderByDescending(x => x.BlogID).Where(y=>y.BlogStatus == true).Take(3).ToList();
            return View(values);
        }
    }
}
