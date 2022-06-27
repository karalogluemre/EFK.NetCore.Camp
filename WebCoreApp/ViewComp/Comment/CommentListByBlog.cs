using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.ViewComp.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager manager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = manager.GetListAll(id);
            return View(values);
        }
    }
}
