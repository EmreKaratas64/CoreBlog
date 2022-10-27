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
    public class EfCommentDal:GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentswithBlog()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(c => c.Blog).ThenInclude(b => b.AppUser).ToList();
            }
        }

        public List<Comment> GetCommentListByBlog()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.AppUser).ThenInclude(y => y.Blogs).ToList();
            }
        }
    }
}
