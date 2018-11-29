using System;
using TestNotification.Controllers.Dtos.Entities;

namespace TestNotification.Controllers.Dtos
{
    public class UserDto : EntityDto<Guid?>, IComparable
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private string FullName
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is UserDto user))
            {
                throw new InvalidCastException($"Not able to cast as '{typeof(UserDto).Name}'.");
            }
            return FullName.CompareTo(user.FullName);
        }
    }
}
