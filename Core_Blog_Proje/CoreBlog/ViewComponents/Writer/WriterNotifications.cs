using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterNotifications : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationDal());

        public IViewComponentResult Invoke()
        {
            var notifications = nm.TGetList().Where(x=>x.NotificationStatus == true).OrderByDescending(x => x.NotificationID).Take(4).ToList();
            return View(notifications);
        }
    }
}
