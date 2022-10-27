using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class NotificationValidator:AbstractValidator<Notification>
    {
        public NotificationValidator()
        {
            RuleFor(x => x.NotificationType).NotEmpty().WithMessage("Bildirim başlığı boş geçilemez");
            RuleFor(x => x.NotificationColor).NotEmpty().WithMessage("Bildirim rengi boş geçilemez");
            RuleFor(x => x.NotificationTypeIcon).NotEmpty().WithMessage("Bildirim ikonu boş geçilemez");
            RuleFor(x => x.NotificationDetails).NotEmpty().WithMessage("Bildirim ikonu boş geçilemez");
        }
    }
}
