using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class NewsLatterController : Controller
    {
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLatter newsLatter)
        {
            
            return PartialView();
        }

    }
}
