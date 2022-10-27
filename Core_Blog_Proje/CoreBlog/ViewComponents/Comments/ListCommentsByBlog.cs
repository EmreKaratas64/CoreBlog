using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Comments
{
    public class ListCommentsByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var comments = cm.GetCommentsByBlog().Where(x => x.BlogID == id).ToList();
            if (comments.Count() == 0)
            {
                TempData["YorumYok"] = "Bu blogda henüz yorum yok. İlk yorumu siz yapın :)";
                return View(comments);
            }
            else
            {
                return View(comments);
            }
             
        }
    }
}
