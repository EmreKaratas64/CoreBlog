using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistics
{
    public class WidgetsTop:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.toplamblog = c.Blogs.Count();
            ViewBag.mesajsayisi = c.Contacts.Count();
            ViewBag.yorumsayisi = c.Comments.Count();

            string api = "a0de910daf94ec99c3ecec304ff15539";
            string connection = "https://api.openweathermap.org/data/2.5/weather?units=metric&mode=xml&q=U%C5%9Fak&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.sicaklik = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
