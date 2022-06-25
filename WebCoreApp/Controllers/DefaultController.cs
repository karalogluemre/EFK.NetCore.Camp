using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
