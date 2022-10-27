using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{

    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            var current_user = await _userManager.FindByNameAsync(User.Identity.Name);
            comment.UserId = current_user.Id;
            comment.CommentDate = DateTime.Now;
            comment.CommentStatus = false;
            cm.TAdd(comment);
            Thread.Sleep(3000);
            return RedirectToAction("BlogReadAll", "Blog", new { id = comment.BlogID });
        }
    }
}
