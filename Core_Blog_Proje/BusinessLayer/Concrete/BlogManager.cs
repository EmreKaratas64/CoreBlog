using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        // bu metod kategoriler, yazarlar, rating tablolarını da getiriyor
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return _blogDal.GetListAll(x=>x.AppUserId == id);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public Blog GetBlogwithCat_User_Rating(int id)
        {
            return _blogDal.GetBlogwithCategoryAppUserBlogRating(id);
        }
    }
}
