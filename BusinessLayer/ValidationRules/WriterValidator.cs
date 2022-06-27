using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresi boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen 50 karakterlik veri girişi yapın.");
        }
    }
}
