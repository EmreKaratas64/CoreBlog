using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public IActionResult CategoryList(int page=1)
        {
            var categories = cm.TGetList().ToPagedList(page,10);
            return View(categories);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("CategoryList", "Category");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        public IActionResult MakeCategoryPassive(int id)
        {
            var value = cm.TGetById(id);
            if(value.CategoryStatus == true)
            {
                value.CategoryStatus = false;
                cm.TUpdate(value);
                TempData["Passivesuccess"] = "Kategori başarıyla pasif hale getirildi";
            }
            else
            {
                TempData["Passivefailure"] = "Kategori zaten pasif durumda";
            }
            return RedirectToAction("CategoryList");
        }

        public IActionResult MakeCategoryActive(int id)
        {
            var value = cm.TGetById(id);
            if(value.CategoryStatus == false)
            {
                value.CategoryStatus = true;
                cm.TUpdate(value);
                TempData["Activesuccess"] = "Kategori başarıyla aktif hale getirildi";
            }
            else
            {
                TempData["Activefailure"] = "Kategori zaten aktif durumda";
            }
            return RedirectToAction("CategoryList");
        }

        public IActionResult BringCategory(int id)
        {
            var category = cm.TGetById(id);
            return View(category);
        }

        public IActionResult EditCategory(Category c)
        {
            var category = cm.TGetById(c.CategoryID);
            category.CategoryName = c.CategoryName;
            category.CategoryDescription = c.CategoryDescription;
            cm.TUpdate(category);
            var jsoncategory = JsonConvert.SerializeObject(category);
            return Json(jsoncategory);
        }
    }
}
