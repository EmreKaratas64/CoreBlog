using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistics
{
    public class WidgetTop2 : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.CevaplanmamisMesaj = c.Contacts.Where(x => x.ContactStatus == true).Count();
            ViewBag.Mailbulteniabone = c.MailSubscribes.Count();
            string wr = "Writer";
            var writer_role = c.Roles.Where(x => x.NormalizedName == wr.ToUpper() || x.Name == wr.ToLower()).FirstOrDefault();
            ViewBag.Yazarsayisi = c.UserRoles.Where(x => x.RoleId == writer_role.Id).Count();
            return View();
        }
    }
}
