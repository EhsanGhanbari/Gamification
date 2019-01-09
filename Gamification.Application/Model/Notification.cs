using System.Collections.Generic;

namespace Gamification.Application.Model
{
    public class Notification : EntityBase
    {
        public string Body { get; set; }
        public bool IsRead { get; set; }
        public bool IsDisabledForAlert { get; set; }
        public ICollection<User> Users { get; set; } 
    }
}
