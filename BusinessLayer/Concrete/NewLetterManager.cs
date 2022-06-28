using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewLetterManager : INewLetterService
    {
        INewsLatterDAL _newLetterDal;
        public NewLetterManager(INewsLatterDAL newLetterDal)
        {
            _newLetterDal = newLetterDal;
        }
        public void AddNewsLetter(NewsLatter newsLatter)
        {
            _newLetterDal.Insert(newsLatter);
        }
    }
}
