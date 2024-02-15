using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaşı ismini boş geçemezssiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezssiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim yolunu boş geçemezssiniz");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapın");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 3 karakterden daha fazla veri girişi yapın");
        }
    }
}
