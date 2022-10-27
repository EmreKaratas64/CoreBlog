using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen ad soyad giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen bir şifre giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage ="Şifreler uyumlu değil!")]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen bir mail adresi giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Cinsiyet")]
        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public bool Gender { get; set; }
    }
}
