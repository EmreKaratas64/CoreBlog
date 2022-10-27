using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blogs
{
    public class LastSharedBlog : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke()
        {
            var son_blog = blogManager.TGetList().Where(y => y.BlogStatus == true).OrderByDescending(x => x.BlogID).Take(1).ToList();
            return View(son_blog);
        }
    }
}
