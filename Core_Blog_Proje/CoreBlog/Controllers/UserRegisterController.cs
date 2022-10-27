using CoreBlog.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class UserRegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailService _emailService;
        Context c = new Context();
        public UserRegisterController(UserManager<AppUser> userManager, IEmailService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult UserRegistration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserRegistration(UserSignUpViewModel p)
        {
            bool exists = c.Users.Any(x => x.UserName == p.UserName || x.Email == p.Mail);

            if (ModelState.IsValid)
            {
                if (!exists)
                {
                    AppUser user = new AppUser()
                    {
                        NameSurname = p.NameSurname,
                        Email = p.Mail,
                        UserName = p.UserName,
                        Gender = p.Gender
                    };
                    var result = await _userManager.CreateAsync(user, p.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "User");
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var link = Url.Action(nameof(VerfiyEmail), "UserRegister", new { userId = user.Id, token }, Request.Scheme, Request.Host.ToString());
                        await _emailService.SendAsync(user.Email, "Mail doğrulama", link);
                        return RedirectToAction("EmailVerification", "UserRegister");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    TempData["Kullaniliyor"] = "Bu kullanıcı adı veya mail zaten kullanılıyor";
                }
            }
            return View(p);
        }

        public async Task<IActionResult> VerfiyEmail(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return BadRequest();
            var result = await _userManager.ConfirmEmailAsync(user, token);
            user.Status = true;
            await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return View();
            }
            return BadRequest();
        }

        public IActionResult EmailVerification() => View();
    }
}
