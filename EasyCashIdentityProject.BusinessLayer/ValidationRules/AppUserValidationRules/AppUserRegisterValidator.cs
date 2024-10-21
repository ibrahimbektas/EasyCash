using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar alanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karekter girilebilir");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 3 karekterlik veri girmeniz gerekli");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eşleşmedi");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz");
        }
    }
}
