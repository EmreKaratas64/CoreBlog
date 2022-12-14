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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetCommentsByBlog()
        {
            return _commentDal.GetCommentListByBlog();
        }

        // bu metod blog ve appuser entity'lerini de içeriyor
        public List<Comment> GetCommentListwithBlog()
        {
            return _commentDal.GetCommentswithBlog();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetList(int id)
        {
            return _commentDal.GetListAll(x=>x.BlogID == id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetListAll();
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
