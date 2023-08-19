using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
	public class AboutValidator:AbstractValidator<About>
	{
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Yapabileceğiniz maksimum açıklama karakteri 1500'tür.");
        }
    }
}
