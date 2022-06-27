using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreApp.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EfWritterRepository());

        [HttpGet]
        public IActionResult CreateWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWriter(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult result = validationRules.Validate(writer);
            if (result.IsValid)
            {
                writer.Status = true;
                writer.About = "Deneme";
                _writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
