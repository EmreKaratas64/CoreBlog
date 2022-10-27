using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı girin")]
        public string UserName { get; set; }

        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
