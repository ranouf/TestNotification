using System;
using System.Collections.Generic;
using TestNotification.Controllers.Dtos.Entities;

namespace TestNotification.Controllers.Dtos.Grouping
{
    public class GroupItemDto<TEntity> : GroupItemDto<TEntity, Guid>
        where TEntity : IEntityDto
    {
    }

    public class GroupItemDto<TEntity, TPrimaryKey>
        where TEntity : IEntityDto<TPrimaryKey>
    {
        public AbstractItemDto Item { get; set; }
        public IEnumerable<TEntity> Items { get; set; }
    }
}
