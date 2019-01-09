using System;

namespace Gamification.Service.DataModel
{
    public class MessageView
    {
        public string Body { get; set; }
        public Guid RecieverUserId { get; set; }
    }
}
