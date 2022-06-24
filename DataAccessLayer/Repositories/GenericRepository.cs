using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class, new()
    {
        public void Delete(T entity)
        {
            using var _context = new ApplicationDbContext();
            _context.Remove(entity);
        }

        public T GetById(int id)
        {
            using var _context = new ApplicationDbContext();
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var _context = new ApplicationDbContext();
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var _context = new ApplicationDbContext();
            _context.Add(entity);
        }

        public void SaveChanges()
        {
            using var _context = new ApplicationDbContext();
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var _context = new ApplicationDbContext();
            _context.Update(entity);
        }
    }
}
