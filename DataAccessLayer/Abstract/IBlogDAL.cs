using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDAL
    {
        ICollection<Blog> ListAllCategory();
        void AddBlog(Blog category);
        void RemoveBlog(Blog category);
        void UpdateBlog(Blog category);
        Blog GetBlog(int id);
    }
}
