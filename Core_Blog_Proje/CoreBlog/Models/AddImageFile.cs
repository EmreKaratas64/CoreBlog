using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class AddImageFile
    {
        public string ImageAdd(IFormFile image)
        {
            var extention = Path.GetExtension(image.FileName);
            var newimagename = Guid.NewGuid() + extention;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProfileImages/", newimagename);
            var stream = new FileStream(location, FileMode.Create);
            image.CopyTo(stream);
            return newimagename;
        }

        public string BlogImageAdd(IFormFile image)
        {
            var extention = Path.GetExtension(image.FileName);
            var newimagename = Guid.NewGuid() + extention;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BlogImages/", newimagename);
            var stream = new FileStream(location, FileMode.Create);
            image.CopyTo(stream);
            return newimagename;
        }
    }
}
