using System.Collections.Generic;

namespace Gamification.Application.Model
{
    public class Darik : EntityBase
    {
        public long Amount { get; set; }
        public ICollection<User> Users { get; set; } 
    }
}
