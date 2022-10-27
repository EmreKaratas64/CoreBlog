using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(i => i.Category).ThenInclude(b => b.Blogs).ThenInclude(u => u.AppUser).ThenInclude(t => t.Blogs).ThenInclude(r => r.BlogRating).ToList();
            }
        }

        public Blog GetBlogwithCategoryAppUserBlogRating(int id)
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(a => a.Category).ThenInclude(b => b.Blogs).ThenInclude(u => u.AppUser).ThenInclude(d => d.Blogs).ThenInclude(e => e.BlogRating).Where(x => x.BlogID == id).FirstOrDefault();
            }
        }
    }
}
