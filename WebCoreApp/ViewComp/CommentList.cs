using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.ViewComp
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName="Emre"
                },
                new UserComment
                {
                    Id=2,
                    UserName="Feyza"
                }
            };
            return View(commentvalues);
        }

    }
}
