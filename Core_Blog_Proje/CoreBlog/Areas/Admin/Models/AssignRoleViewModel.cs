using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Models
{
    public class AssignRoleViewModel
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public bool Exists { get; set; }
    }
}
