using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Models
{
    public class RoleModelView
    {
        [Required(ErrorMessage = "Lütfen rol ismini giriniz")]
        public string RoleName { get; set; }
    }
}
