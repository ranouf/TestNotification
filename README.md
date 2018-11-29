# TestNotification
This a test project for an issue with NsWag https://github.com/RSuter/NSwag/issues/1766

NswagStudio failed to generate _AbstractItemDto.fromJS_ correctly. With this repository, I can show how to reproduce the issue.

The purpose of this project is to show a list of Notifications.

Here is a example of what the API Returned:
```
{  
   "totalCount":20,
   "groupItems":[  
      {  
         "item":{  
            "key":{  
               "action":"NewUserDto",
               "label":null,
               "entity":{  
                  "firstname":"test",
                  "lastname":"test",
                  "id":null
               },
               "discriminator":"UserDto",
               "createdBy":null,
               "createdAt":"2018-11-29T13:35:33.4585017-05:00",
               "id":"00000000-0000-0000-0000-000000000000"
            },
            "discriminator":"NotificationDto"
         },
         "items":[  
            {  
               "action":"NewUserDto",
               "label":"test test",
               "entity":{  
                  "firstname":"test",
                  "lastname":"test",
                  "id":null
               },
               "discriminator":"UserDto",
               "createdBy":"Samantha Carter",
               "createdAt":"2018-11-29T13:35:33.4477673-05:00",
               "id":"457c3d5c-3dc5-4580-9545-693c2a1af841"
            },
            {  
               "action":"EditUserDto",
               "label":"test test",
               "entity":{  
                  "firstname":"John",
                  "lastname":"Smmith",
                  "id":null
               },
               "discriminator":"UserDto",
               "createdBy":"Samantha Carter",
               "createdAt":"2018-11-29T13:35:33.4572957-05:00",
               "id":"daee153c-385c-4440-93c9-0c73e90bdb75"
            }
         ]
      }
   ],
   "hasNext":false
}
```

the groupItems[0].Item.Key can be a NotificationDto, UserDto of string.
