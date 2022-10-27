using CoreBlog.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult RolesPage()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleModelView p)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole()
                {
                    Name = p.RoleName
                };

                var result = await _roleManager.CreateAsync(role);

                if (result.Succeeded)
                {
                    TempData["RoleAddSuccess"] = "Rol başarıyla eklendi";
                    return RedirectToAction("RolesPage", "AdminRole");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(p);
        }


        public async Task<IActionResult> ChangeRoleStatus(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role.RoleStatus == true)
            {
                role.RoleStatus = false;
                var result = await _roleManager.UpdateAsync(role);
                TempData["RolePassiveSuccess"] = "Rol başarıyla pasif hale getirildi";
            }
            else
            {
                role.RoleStatus = true;
                var result = await _roleManager.UpdateAsync(role);
                TempData["RoleActiveSuccess"] = "Rol başarıyla aktif hale getirildi";
            }
            return RedirectToAction("RolesPage");
        }

        public IActionResult UsersRoleList()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;
            ViewBag.UserNameSurname = user.NameSurname;

            var user_roles = await _userManager.GetRolesAsync(user);

            List<AssignRoleViewModel> model = new List<AssignRoleViewModel>();

            foreach (var item in roles)
            {
                AssignRoleViewModel m = new AssignRoleViewModel();
                m.RoleID = item.Id;
                m.RoleName = item.Name;
                m.Exists = user_roles.Contains(item.Name);
                model.Add(m);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<AssignRoleViewModel> p)
        {
            var userid = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);

            foreach (var item in p)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }

            return RedirectToAction("UsersRoleList");
        }
    }
}
