using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreBlog.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        MailSubscribeManager msm = new MailSubscribeManager(new EfMailSubscribeDal());
        AddImageFile addImg = new AddImageFile();
        Context c = new Context();

        private readonly UserManager<AppUser> _userManager;

        public BlogController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Bloglar(int page = 1)
        {
            var values = bm.GetBlogListWithCategory().Where(x => x.BlogStatus == true).ToList().ToPagedList(page, 15);
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            var value = bm.GetBlogwithCat_User_Rating(id);
            ViewBag.comment_number = c.Comments.Where(x => x.BlogID == id).Count();
            return View(value);
        }

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SubscribeMail(MailSubscribe m)
        {
            bool exists = c.MailSubscribes.Any(x => x.Mail == m.Mail);
            if (exists)
            {
                TempData["MailFail"] = "Zaten bir mail aboneliğiniz bulunmaktadır";
                return RedirectToAction("Bloglar", "Blog");
            }
            m.MailStatus = true;
            msm.TAdd(m);
            TempData["MailSuccess"] = "Mail aboneliğiniz başarıyla gerçekleştirilmiştir";
            return RedirectToAction("Bloglar", "Blog");
        }

        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> WriterBlogs()
        {
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            int writerid = currentWriter.Id;
            var values = bm.GetBlogListWithCategory().Where(x => x.AppUserId == writerid && x.BlogStatus == true).ToList();
            return View(values);
        }

        [HttpGet]
        [Authorize(Roles = "Writer")]
        public IActionResult AddBlog()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> kategoriler = (from x in cm.TGetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.kategori = kategoriler;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> AddBlog(BlogAddViewModel p)
        {
            BlogValidator bv = new BlogValidator();
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> kategoriler = (from x in cm.TGetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.kategori = kategoriler;
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                Blog blog = new Blog()
                {
                    BlogTitle = p.blogTitle,
                    BlogContent = p.blogContent
                };
                if (p.blogImage != null)
                {
                    blog.BlogImage = addImg.BlogImageAdd(p.blogImage);
                    blog.BlogThumbnailImage = blog.BlogImage;
                }

                ValidationResult results = bv.Validate(blog);

                if (results.IsValid)
                {
                    blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    blog.BlogStatus = true;
                    blog.AppUserId = currentWriter.Id;
                    blog.CategoryID = p.categoryID;
                    bm.TAdd(blog);
                    return RedirectToAction("WriterBlogs", "Blog");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
            }

            return View(p);
        }

        [Authorize(Roles = "Writer")]
        public IActionResult DeleteBlog(int id)
        {
            var blog = bm.TGetById(id);
            blog.BlogStatus = false;
            bm.TUpdate(blog);
            return RedirectToAction("WriterBlogs", "Blog");
        }

        [HttpGet]
        [Authorize(Roles = "Writer")]
        public IActionResult UpdateBlog(int id)
        {
            var blog = bm.TGetById(id);
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> kategoriler = (from x in cm.TGetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.kategori = kategoriler;
            BlogEditViewModel model = new BlogEditViewModel();
            model.blogID = id;
            model.blogTitle = blog.BlogTitle;
            model.blogContent = blog.BlogContent;
            model.categoryID = blog.CategoryID;
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> UpdateBlog(BlogEditViewModel p)
        {
            BlogValidator bv = new BlogValidator();
            var currentWriter = await _userManager.FindByNameAsync(User.Identity.Name);
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> kategoriler = (from x in cm.TGetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.kategori = kategoriler;
            if (ModelState.IsValid)
            {
                var blog = bm.TGetById(p.blogID);
                blog.BlogTitle = p.blogTitle;
                blog.BlogContent = p.blogContent;
                if (p.blogImage != null && p.resimDegistir == true)
                {
                    blog.BlogImage = addImg.BlogImageAdd(p.blogImage);
                    blog.BlogThumbnailImage = blog.BlogImage;
                }
                ValidationResult results = bv.Validate(blog);

                if (results.IsValid)
                {
                    blog.AppUserId = currentWriter.Id;
                    blog.CategoryID = p.categoryID;
                    bm.TUpdate(blog);
                    return RedirectToAction("WriterBlogs");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }

            }
            return View(p);
        }
    }
}
