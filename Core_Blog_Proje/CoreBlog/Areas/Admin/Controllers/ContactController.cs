using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());

        public IActionResult ContactMessages()
        {
            var values = cm.TGetList();
            return View(values);
        }

        public IActionResult MakeContactRead(int id)
        {
            var contact = cm.TGetById(id);
            contact.ContactStatus = false;
            cm.TUpdate(contact);
            return RedirectToAction("ContactMessages");
        }

        public IActionResult DeleteContact(int id)
        {
            var contact_msg = cm.TGetById(id);
            cm.TDelete(contact_msg);
            return RedirectToAction("ContactMessages");
        }
    }
}
