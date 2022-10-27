using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        public IActionResult AboutPage()
        {
            var value = aboutManager.TGetList().OrderBy(x => x.AboutID).Take(1).ToList();
            return View(value);
        }


        public PartialViewResult AboutSocial()
        {
            return PartialView();
        }
    }
}
