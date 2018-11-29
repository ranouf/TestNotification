using Newtonsoft.Json;
using System.Runtime.Serialization;
using TestNotification.Converters;

namespace TestNotification.Controllers.Dtos.Grouping
{
    [JsonConverter(typeof(JsonInheritanceConverter))]
    [KnownType(typeof(ItemDto<string>))]
    [KnownType(typeof(ItemDto<UserDto>))]
    [KnownType(typeof(ItemDto<NotificationDto>))]
    [JsonSchemaFlatten]
    public abstract class AbstractItemDto
    {
        public abstract string Discriminator { get; }
    }
}
