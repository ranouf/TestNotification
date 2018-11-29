using System;
using System.Collections.Generic;
using TestNotification.Controllers.Dtos.Entities;

namespace TestNotification.Controllers.Dtos.Grouping
{
    public class GroupedResultDto<TEntity> : GroupedResultDto<TEntity, Guid>
        where TEntity : IEntityDto
    {
    }

    public class GroupedResultDto<TEntity, TPrimaryKey>
        where TEntity : IEntityDto<TPrimaryKey>
    {
        public int TotalCount { get; set; }
        public IEnumerable<GroupItemDto<TEntity, TPrimaryKey>> GroupItems { get; set; }
        public bool HasNext { get; set; }
    }
}
