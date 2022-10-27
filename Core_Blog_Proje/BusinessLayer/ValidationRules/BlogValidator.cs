using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {

        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog aşlığı boş olamaz");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("Blog başlığı 3 karakterden fazla olmalıdır");
            RuleFor(x => x.BlogTitle).MaximumLength(40).WithMessage("Blog başlığı 40 karakterden fazla olamaz");
            RuleFor(x => x.BlogContent).MinimumLength(100).WithMessage("Blog içeriği 100 karakterden fazla olmalıdır");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş olamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog resmi boş olamaz");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Blog küçük resmi boş olamaz");
        }

    }
}
