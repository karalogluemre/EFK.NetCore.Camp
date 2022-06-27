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
    public class WriterManager : IWritterService
    {
        IWritterDAL _writterDAL;
        public WriterManager(IWritterDAL writterDAL)
        {
            _writterDAL = writterDAL;
        }
        public void WriterAdd(Writer writer)
        {
            _writterDAL.Insert(writer);
        }
    }
}
