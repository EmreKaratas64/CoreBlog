using CoreBlog.Areas.Admin.Models;
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

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminRegisterController : Controller
    {
        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailService _emailService;
        AddImageFile addimg = new AddImageFile();

        public AdminRegisterController(UserManager<AppUser> userManager,IEmailService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAdmin(AdminSignUpViewModel p)
        {
            bool exists = c.Users.Any(x => x.UserName == p.userName || x.Email == p.mail);

            if (ModelState.IsValid)
            {
                if (!exists)
                {
                    AppUser user = new AppUser()
                    {
                        NameSurname = p.nameSurname,
                        UserName = p.userName,
                        Email = p.mail,
                        Gender = p.Gender
                    };
                    if (p.Image != null)
                        user.ImageUrl = addimg.ImageAdd(p.Image);
                    var result = await _userManager.CreateAsync(user, p.password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Admin");
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var link = Url.Action("VerfiyAdminEmail", "AdminRegister", new { userId = user.Id, token }, Request.Scheme, Request.Host.ToString());
                        await _emailService.SendAsync(user.Email, "Mail doğrulama", link);
                        return RedirectToAction("AdminEmailVerification", "AdminRegister");
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
                    TempData["AdminKullaniliyor"] = "Bu kullanıcı adı veya mail zaten kullanılıyor";
                }
            }

            return View(p);
        }

        public IActionResult AdminEmailVerification() => View();

        public async Task<IActionResult> VerfiyAdminEmail(string userId, string token)
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
    }
}
