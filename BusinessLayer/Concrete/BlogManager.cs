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
        public IBlogDAL _blogDal;
        public BlogManager(IBlogDAL blogDal)
        {
            _blogDal = blogDal;
        }
        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public Blog BlogById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetAllListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public void Remove(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void SaveChanges()
        {
            _blogDal.SaveChanges();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.Id == id);
        }

        public List<Blog> GetBlogListByWritter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }
    }
}
