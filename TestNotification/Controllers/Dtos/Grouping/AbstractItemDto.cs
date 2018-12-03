using Newtonsoft.Json;
using TestNotification.Converters;

namespace TestNotification.Controllers.Dtos.Grouping
{
    [JsonConverter(typeof(JsonInheritanceConverter))]
    [NJsonKnownTypeAttribute(typeof(ItemDto<string>))]
    [NJsonKnownTypeAttribute(typeof(ItemDto<UserDto>))]
    [NJsonKnownTypeAttribute(typeof(ItemDto<NotificationDto>))]
    public interface IItemDto
    {
        string Discriminator { get; }
    }
}
