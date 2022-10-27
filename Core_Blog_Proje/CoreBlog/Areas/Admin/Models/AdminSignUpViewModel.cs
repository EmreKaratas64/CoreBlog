using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Models
{
    public class AdminSignUpViewModel
    {
        [Required(ErrorMessage ="Lütfen ad ve soyad bilgisini giriniz")]
        public string nameSurname { get; set; }

        public IFormFile Image { get; set; }

        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage ="Lütfen mail adresini giriniz")]
        public string mail { get; set; }

        [Required(ErrorMessage ="Lütfen bir şifre giriniz")]
        public string password { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi onaylayınız")]
        [Compare("password",ErrorMessage ="Şifreler uyumlu değil")]
        public string passwordConfirm { get; set; }

        public bool Gender { get; set; }
    }
}
