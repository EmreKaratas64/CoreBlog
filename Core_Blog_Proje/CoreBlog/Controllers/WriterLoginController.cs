using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{

    [AllowAnonymous]
    public class WriterLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public WriterLoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult LoginWriter()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginWriter(WriterLoginViewModel p)
        {
            var writers = await _userManager.GetUsersInRoleAsync("Writer");
            bool exists = writers.Any(x => x.UserName == p.username);
            if (exists)
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(p.username, p.password, true, true);
                    if (!result.IsNotAllowed)
                    {
                        if (result.Succeeded)
                        {
                            return RedirectToAction("DashboardPage", "Dashboard");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Lütfen mail adresinizi doğruladığınızdan emin olunuz");
                    }
                   
                }
                return View(p);
            }
            
            return View();
        }


        public async Task<IActionResult> LogOutWriter()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LoginWriter", "WriterLogin");
        }
    }
}