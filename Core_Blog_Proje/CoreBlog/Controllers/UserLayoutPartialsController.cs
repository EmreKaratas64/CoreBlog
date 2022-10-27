using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class UserLayoutPartialsController : Controller
    {

        public PartialViewResult HeaderTop()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}
