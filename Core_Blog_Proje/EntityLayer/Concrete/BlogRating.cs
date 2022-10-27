using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        [Key]
        public int BlogRatingID { get; set; }

        public int BlogID { get; set; }

        public int BlogTotalScore { get; set; }

        public int BlogRatingCount { get; set; }

        public Blog Blog { get; set; }
    }
}
