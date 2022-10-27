using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.Comments
{
    public class CommentsToBeApproved : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke()
        {
            var comments_waits_approval = cm.GetCommentListwithBlog().Where(x => x.CommentStatus == false).ToList();
            return View(comments_waits_approval);
        }
    }
}
