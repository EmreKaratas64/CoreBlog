using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [Authorize(Roles ="Writer")]
    public class WriterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        AddImageFile addimg = new AddImageFile();

        CommentManager commentManager = new CommentManager(new EfCommentDal());

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterSettings()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            WriterEditViewModel model = new WriterEditViewModel();
            model.ID = currentWriter.Id;
            model.namesurname = currentWriter.NameSurname;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> WriterSettings(WriterEditViewModel p)
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                currentWriter.NameSurname = p.namesurname;
                if (p.Image != null)
                    currentWriter.ImageUrl = addimg.ImageAdd(p.Image);
                if (p.sifredegistir == true)
                    currentWriter.PasswordHash = _userManager.PasswordHasher.HashPassword(currentWriter, p.password);
                var result = await _userManager.UpdateAsync(currentWriter);
                if (result.Succeeded)
                {
                    return RedirectToAction("LogOutWriter", "WriterLogin");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(p);
        }

        public async Task<IActionResult> CommentsByWriter()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            var comments = commentManager.GetCommentListwithBlog().Where(x => x.Blog.AppUser.Id == currentWriter.Id).ToList();
            return View(comments);
        }

    }
}
