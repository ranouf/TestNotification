using System;
using TestNotification.Controllers.Dtos.Entities;

namespace TestNotification.Controllers.Dtos
{
    public class NotificationDto : EntityDto, IEntityDto, IComparable
    {
        public string Action { get; set; }
        public string Label { get; set; }
        public object Entity { get; set; }
        public string Discriminator { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is NotificationDto notificationDto))
            {
                throw new InvalidCastException($"Not able to cast as '{typeof(NotificationDto).Name}'.");
            }
            return CreatedAt.CompareTo(notificationDto.CreatedAt);
        }
    }
}
