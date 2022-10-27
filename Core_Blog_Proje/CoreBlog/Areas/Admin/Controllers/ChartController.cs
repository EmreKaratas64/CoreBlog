using CoreBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ChartController : Controller
    {
        public IActionResult ChartPage()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> lists = new List<CategoryClass>();

            lists.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 5
            });

            lists.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 8
            });

            lists.Add(new CategoryClass
            {
                categoryname = "Seyhat",
                categorycount = 12
            });

            lists.Add(new CategoryClass
            {
                categoryname = "Kitap",
                categorycount = 18
            });


            return Json(new {jsonlist=lists });
        }
    }
}
