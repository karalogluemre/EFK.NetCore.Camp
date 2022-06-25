using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public ICategoryDAL _categoryDAl;
        public CategoryManager(ICategoryDAL categoryDAl)
        {
            _categoryDAl = categoryDAl;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDAl.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            _categoryDAl.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDAl.Update(category);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDAl.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDAl.GetListAll();
        }

        public void SaveChanges()
        {
            _categoryDAl.SaveChanges();
        }
    }
}
