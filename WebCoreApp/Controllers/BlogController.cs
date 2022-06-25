using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
