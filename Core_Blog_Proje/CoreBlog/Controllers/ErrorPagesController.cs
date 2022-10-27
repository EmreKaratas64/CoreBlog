using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class ErrorPagesController : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
