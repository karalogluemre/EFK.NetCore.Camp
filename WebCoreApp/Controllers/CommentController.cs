using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.Status = true;
            comment.BlogId = 2;
            _manager.Add(comment);
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var data = _manager.GetListAll(id);
            return PartialView(data); 
        }

    }
}
