using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //fluentvalidation kuralları burada tanımlanır
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en az 100 karakterden büyük olmamalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel  boş geçilemez");
        }
    }
}
