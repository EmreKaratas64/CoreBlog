using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class WriterLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen bir kullancı adı giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen bir şifre giriniz")]
        public string password { get; set; }
    }
}
