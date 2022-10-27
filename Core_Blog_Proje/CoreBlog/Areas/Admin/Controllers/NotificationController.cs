using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EfNotificationDal());
        public IActionResult NotificationPage()
        {
            return View();
        }

        public IActionResult ListNotifications()
        {
            var notifications = nm.TGetList();
            var json_notifications = JsonConvert.SerializeObject(notifications);
            return Json(json_notifications);
        }

        public IActionResult ChangeNotificationStatus(int id)
        {
            var notification = nm.TGetById(id);
            if (notification.NotificationStatus == true)
            {
                notification.NotificationStatus = false;
                nm.TUpdate(notification);
                TempData["PasifBasari"] = "Bildirim başarıyla pasif hale getirildi";
            }
            else
            {
                notification.NotificationStatus = true;
                nm.TUpdate(notification);
                TempData["AktifBasari"] = "Bildirim başarıyla aktif hale getirildi";
            }
            return RedirectToAction("NotificationPage", "Notification");
        }

        public IActionResult BringNotification(int id)
        {
            var notification = nm.TGetById(id);
            return View(notification);
        }

        public IActionResult EditNotification(Notification n)
        {
            NotificationValidator nv = new NotificationValidator();
            ValidationResult results = nv.Validate(n);
            if (results.IsValid)
            {
                var notification = nm.TGetById(n.NotificationID);
                notification.NotificationType = n.NotificationType;
                notification.NotificationTypeIcon = n.NotificationTypeIcon;
                notification.NotificationDetails = n.NotificationDetails;
                notification.NotificationColor = n.NotificationColor;
                notification.NotificationDate = DateTime.Now;
                nm.TUpdate(notification);
                var json_notification = JsonConvert.SerializeObject(notification);
                return Json(json_notification);
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}
