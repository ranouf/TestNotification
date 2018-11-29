using System;

namespace TestNotification.Controllers.Dtos.Entities
{
    public interface IEntityDto : IEntityDto<Guid>
    {
    }

    public interface IEntityDto<T> : IDto
    {
        T Id { get; set; }
    }
}
