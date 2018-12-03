using System;

namespace TestNotification.Controllers.Dtos.Grouping
{
    public class ItemDto<T> : IItemDto
        where T : IComparable
    {
        public T Key { get; set; }
        public override string Discriminator
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is ItemDto<T> item))
            {
                throw new InvalidCastException($"Not able to cast as '{typeof(T).Name}'.");
            }
            return Key.CompareTo(item.Key);
        }
    }
}
