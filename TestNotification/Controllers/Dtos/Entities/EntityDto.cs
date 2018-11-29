using System;

namespace TestNotification.Controllers.Dtos.Entities
{
    public class EntityDto : EntityDto<Guid>
    {
    }

    public class EntityDto<T> : IEntityDto<T>
    {
        public T Id { get; set; }
    }
}
