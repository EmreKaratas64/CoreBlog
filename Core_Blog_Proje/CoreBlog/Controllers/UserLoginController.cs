using CoreBlog.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class UserLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public UserLoginController(SignInManager<AppUser> userManager)
        {
            _signInManager = userManager;
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (!result.IsNotAllowed)
                {
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Bloglar", "Blog");
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
            return View();
        }

        public async Task<IActionResult> LogOutUser()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("UserLogin", "UserLogin");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
