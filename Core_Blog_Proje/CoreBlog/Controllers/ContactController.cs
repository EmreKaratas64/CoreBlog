using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        public IActionResult ContactPage()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult ContactSendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult ContactSendMessage(Contact contact)
        {

            contact.ContactDate = DateTime.Now;
            contactManager.TAdd(contact);
            TempData["MesajBasari"] = "Mesajınız başarıyla gönderilmiştir";
            return RedirectToAction("ContactPage", "Contact");
        }
    }
}
