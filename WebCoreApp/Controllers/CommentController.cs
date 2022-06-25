using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class CommentController : Controller
    {
        public CommentManager _manager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var data = _manager.GetListAll(id);
            return PartialView(data); 
        }

    }
}
