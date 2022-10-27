using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage ="Lütfen mesaj konusunu giriniz")]
        [MinLength(2,ErrorMessage ="Mesaj konusunu 2 karakterden fazla olmalıdır")]
        [MaxLength(50,ErrorMessage ="Mesaj konusunu 50 karakterden fazla olamaz")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Lütfen alıcının mail adresini giriniz")]
        public string AlıcıMail { get; set; }

        [Required(ErrorMessage = "Lütfen mesaj içeriğini giriniz")]
        [MinLength(30, ErrorMessage = "Mesaj içeriği 30 karakterden fazla olmalıdır")]
        public string MessageDetails { get; set; }


    }
}
