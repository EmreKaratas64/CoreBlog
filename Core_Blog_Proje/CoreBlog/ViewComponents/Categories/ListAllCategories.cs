using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Categories
{
    public class ListAllCategories:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList().Where(x => x.CategoryStatus == true).ToList();
            return View(values);
        }
    }
}
