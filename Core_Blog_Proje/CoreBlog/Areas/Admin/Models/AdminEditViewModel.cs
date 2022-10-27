using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Models
{
    public class AdminEditViewModel
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage ="Lütfen isim ve soyisim giriniz")]
        public string nameSurname { get; set; }

        public IFormFile Image { get; set; }

        public string password { get; set; }

        [Compare("password",ErrorMessage ="Şifreler aynı değil")]
        public string passwordConfirm { get; set; }

        public bool passwordChange { get; set; }
    }
}
