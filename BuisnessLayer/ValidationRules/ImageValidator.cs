using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezssiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçemezssiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezssiniz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen 20 karakterden daha az veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Lütfen 8 karakterden daha fazla veri girişi yapın");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen 20 karakterden daha fazla veri girişi yapın");
        }
    }
}
