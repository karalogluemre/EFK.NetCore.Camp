using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryManager _manager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var data = _manager.GetList();
            return View(data);
        }
    }
}
