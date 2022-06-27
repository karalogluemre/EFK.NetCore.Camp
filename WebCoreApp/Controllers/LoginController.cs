using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
