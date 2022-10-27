using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }

        public string ImageUrl { get; set; }

        public List<Blog> Blogs { get; set; }

        public virtual ICollection<Message> WriterSender { get; set; }

        public virtual ICollection<Message> WriterReceiver { get; set; }

        public bool Status { get; set; }

        public bool Gender { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
