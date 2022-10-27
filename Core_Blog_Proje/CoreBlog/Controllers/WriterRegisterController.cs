using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class WriterRegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailService _emailService;
        Context c = new Context();

        public WriterRegisterController(UserManager<AppUser> userManager,IEmailService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        AddImageFile addimg = new AddImageFile();

        [HttpGet]
        public IActionResult RegisterWriter()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterWriter(WriterSignUpViewModel p)
        {
            bool exists = c.Users.Any(x => x.UserName == p.username || x.Email == p.mail);

            if (ModelState.IsValid)
            {
                if (!exists)
                {
                    AppUser user = new AppUser()
                    {
                        NameSurname = p.namesurname,
                        UserName = p.username,
                        Email = p.mail,
                        Gender = p.Gender
                    };
                    if (p.Image != null)
                        user.ImageUrl = addimg.ImageAdd(p.Image);

                    var result = await _userManager.CreateAsync(user, p.password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Writer");
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var link = Url.Action("VerfiyEmail", "UserRegister", new { userId = user.Id, token }, Request.Scheme, Request.Host.ToString());
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
                    TempData["YazarKullaniliyor"] = "Bu kullanıcı adı veya mail zaten kullanılıyor";
                }

            }
            return View(p);
        }
    }
}
// 123456
// mr186K*
// 123456aA*