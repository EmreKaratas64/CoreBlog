using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [Authorize(Roles ="Writer")]
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EfNotificationDal());

        public IActionResult ListAllNotifications()
        {
            var values = nm.TGetList();
            return View(values);
        }
    }
}
