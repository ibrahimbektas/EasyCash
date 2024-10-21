using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage ="Ad Alanı Zorunludur")]
        //[Display(Name ="İsim")]
        //[MaxLength(30,ErrorMessage ="En fazla 30 karekter girbilirsiniz")]
        public string Name;
        public string Surname;
        public string Email;
        public string Username;
        public string Password;
        public string ConfirmPassword;
    }
}
