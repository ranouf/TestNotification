using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using TestNotification.Controllers.Dtos;
using TestNotification.Controllers.Dtos.Grouping;

namespace TestNotification.Controllers
{
    [Route("api/[controller]")]
    public class NotificationController : Controller
    {
        /// <summary>
        /// In this sample, the action will return a GroupedResultDto of Notification with a key typed as:
        /// - NotificationDto, if type == 1
        /// - string, if type == 2
        /// - UserDto, if type == 3
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(GroupedResultDto<NotificationDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll([FromQuery]int type)
        {
            GroupedResultDto<NotificationDto> result = null;

            var items = new List<NotificationDto>()
            {
                new NotificationDto()
                {
                    Action = "NewUserDto",
                    Id = Guid.NewGuid(),
                    Label = "test test",
                    Entity = new UserDto()
                    {
                        Firstname = "test",
                        Lastname = "test"
                    },
                    Discriminator = "UserDto",
                    CreatedAt = DateTimeOffset.Now,
                    CreatedBy = "Samantha Carter"
                },
                new NotificationDto()
                {
                    Action = "EditUserDto",
                    Id = Guid.NewGuid(),
                    Label = "test test",
                    Entity = new UserDto()
                    {
                        Firstname = "John",
                        Lastname = "Smmith"
                    },
                    Discriminator = "UserDto",
                    CreatedAt = DateTimeOffset.Now,
                    CreatedBy = "Samantha Carter"
                }
            };
            if (type == 1)
            {
                result = new GroupedResultDto<NotificationDto>()
                {
                    HasNext = false,
                    TotalCount = 20,
                    GroupItems = new List<GroupItemDto<NotificationDto>>() {
                        new GroupItemDto<NotificationDto>()
                        {
                            Item = new ItemDto<NotificationDto>()
                            {
                                Key = new NotificationDto()
                                {
                                    Action = "NewUserDto",
                                    Entity = new UserDto()
                                    {
                                        Firstname = "test",
                                        Lastname = "test"
                                    },
                                    Discriminator = "UserDto",
                                    CreatedAt = DateTimeOffset.Now
                                }
                            },
                            Items = items //Useless for this example
                        }
                    }
                };
            }
            else if (type == 2)
            {
                result = new GroupedResultDto<NotificationDto>()
                {
                    HasNext = false,
                    TotalCount = 20,
                    GroupItems = new List<GroupItemDto<NotificationDto>>() {
                        new GroupItemDto<NotificationDto>()
                        {
                            Item = new ItemDto<string>()
                            {
                                Key = "test"
                            },
                            Items = items //Useless for this example
                        }
                    }
                };
            }
            else if (type == 3)
            {
                result = new GroupedResultDto<NotificationDto>()
                {
                    HasNext = false,
                    TotalCount = 20,
                    GroupItems = new List<GroupItemDto<NotificationDto>>() {
                        new GroupItemDto<NotificationDto>()
                        {
                            Item = new ItemDto<UserDto>()
                            {
                                Key = new UserDto()
                                {
                                    Firstname = "test",
                                    Lastname = "test"
                                },
                            },
                            Items = items //Useless for this example
                        }
                    }
                };
            }

            return new ObjectResult(result);
        }
    }
}
