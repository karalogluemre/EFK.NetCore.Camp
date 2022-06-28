using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class NewsLatterController : Controller
    {
        NewLetterManager manager = new NewLetterManager(new EfNewsLatterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLatter newsLatter)
        {
            newsLatter.Status= true;
            manager.AddNewsLetter(newsLatter);
            return PartialView();
        }

    }
}
