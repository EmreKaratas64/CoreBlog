using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterMessages : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageDal());

        private readonly UserManager<AppUser> _userManager;

        public WriterMessages(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            int id = currentWriter.Id;
            var messagesInBox = mm.GetMessageInBox(id).OrderByDescending(x => x.MessageID).Take(4).ToList();
            return View(messagesInBox);
        }
    }
}
