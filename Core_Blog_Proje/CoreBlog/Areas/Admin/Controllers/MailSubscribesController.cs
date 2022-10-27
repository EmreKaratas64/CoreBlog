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
    public class MailSubscribesController : Controller
    {
        MailSubscribeManager ms = new MailSubscribeManager(new EfMailSubscribeDal());

        public IActionResult NewsLetter()
        {
            var values = ms.TGetList();
            return View(values);
        }

            public IActionResult DeleteSubscribe(int id)
        {
            var value = ms.TGetById(id);
            ms.TDelete(value);
            return RedirectToAction("NewsLetter");
        }
    }
}
