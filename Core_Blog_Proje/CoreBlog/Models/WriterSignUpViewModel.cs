using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class WriterSignUpViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı ve soyadınızı giriniz")]
        public string namesurname { get; set; }

        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Lütfen bir kullancı adı giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "lütfen bir mail adresi giriniz")]
        public string mail { get; set; }

        [Required(ErrorMessage = "lütfen bir şifre giriniz")]
        public string password { get; set; }

        [Compare("password", ErrorMessage = "şifreler uyumlu değil!")]
        public string passwordconfirm { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public bool Gender { get; set; }
    }
}
