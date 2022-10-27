using CoreBlog.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminLoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(AdminLoginViewModel p)
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            var moderators = await _userManager.GetUsersInRoleAsync("Moderator");
            bool exists = admins.Any(x => x.UserName == p.username);
            bool exists2 = moderators.Any(x => x.UserName == p.username);
            if (exists || exists2)
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(p.username, p.password, true, true);
                    if (!result.IsNotAllowed)
                    {
                        if (result.Succeeded)
                        {
                            Thread.Sleep(4000);
                            return RedirectToAction("MainPage", "Widget");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
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

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LogIn", "AdminLogin");
        }
    }
}
