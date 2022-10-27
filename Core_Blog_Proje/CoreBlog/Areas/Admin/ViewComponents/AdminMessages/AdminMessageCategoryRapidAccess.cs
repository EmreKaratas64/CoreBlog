using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.AdminMessages
{
    public class AdminMessageCategoryRapidAccess:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public AdminMessageCategoryRapidAccess(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentAdmin = await _userManager.FindByNameAsync(User.Identity.Name);
            var gelenmesajsayi = messageManager.GetMessageInBox(currentAdmin.Id).Count();
            ViewBag.gelen_mesaj_sayi = gelenmesajsayi;
            var gidenmesajsayi = messageManager.GetMessageSendBox(currentAdmin.Id).Count();
            ViewBag.gonderilen_mesaj = gidenmesajsayi;

            var kategoriler = categoryManager.TGetList();
            return View(kategoriler);
        }
    }
}
