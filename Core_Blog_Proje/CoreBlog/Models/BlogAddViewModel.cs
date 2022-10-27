using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class BlogAddViewModel
    {
        [Required(ErrorMessage ="Lütfen blog başlığı giriniz")]
        public string blogTitle { get; set; }

        [Required(ErrorMessage = "Lütfen blog içeriğini giriniz")]
        public string blogContent { get; set; }

        [Required(ErrorMessage ="Lütfen blog için bir resim seçiniz")]
        public IFormFile blogImage { get; set; }

        [Required(ErrorMessage ="Lütfen kategori seçimini yapınız")]
        public int categoryID { get; set; }
    }
}
