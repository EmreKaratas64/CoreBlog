using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class WriterEditViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı ve soyadınızı giriniz")]
        public string namesurname { get; set; }

        public IFormFile Image { get; set; }

        public string password { get; set; }

        [Compare("password", ErrorMessage = "şifreler uyumlu değil!")]
        public string passwordconfirm { get; set; }

        public bool sifredegistir { get; set; }


    }
}
