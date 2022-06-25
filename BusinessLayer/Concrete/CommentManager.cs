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
        public ICommentDAL _commentDal;
        public CommentManager(ICommentDAL commentDal)
        {
            _commentDal = commentDal;
        }
        public void Add(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetListAll(int id)
        {
            return _commentDal.GetListAll(z => z.Id == id);
        }
    }
}
