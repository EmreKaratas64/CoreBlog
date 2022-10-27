using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        public IActionResult CommentsPage()
        {
            var comments = cm.GetCommentListwithBlog();
            return View(comments);
        }

        public IActionResult MakeCommentActive(int id)
        {
            var comment = cm.TGetById(id);
            if (comment.CommentStatus != true)
            {
                comment.CommentStatus = true;
                cm.TUpdate(comment);
                TempData["CommentAktif"] = "Yorum başarıyla aktif hale getirildi";
            }
            else
            {
                TempData["PasifYapılamaz"] = "Aktif olan yorumlar pasif hale getirilemez !";
            }

            return RedirectToAction("CommentsPage", "Comment");
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = cm.TGetById(id);
            cm.TDelete(comment);
            TempData["YorumSilmeBasari"] = "Yorum başarıyla silindi !";
            return RedirectToAction("CommentsPage", "Comment");
        }
    }
}
