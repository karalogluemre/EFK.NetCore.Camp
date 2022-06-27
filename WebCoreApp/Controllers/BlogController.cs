using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class BlogController : Controller
    {
        public BlogManager _manager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var data = _manager.GetAllListWithCategory();
            return View(data);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = _manager.GetBlogById(id); 
            return View(values);
        }
    }
}
