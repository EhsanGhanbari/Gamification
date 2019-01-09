using System.Collections.Generic;
using Gamification.Shared;

namespace Gamification.Application.Model
{
    public sealed class User : EntityBase
    {
        public User() { }

        public User(Profile profile)
        {
            Profile = profile;
        }

        public User(string email, string password, string mobile)
        {
            Email = email;
            Password = password;
            Mobile = mobile;
        }

        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Profile Profile { get; set; }
        public bool IsBlocked { get; set; }
        public UserLevel Level { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Notification> Notifications { get; set; } 

    }

    public class Profile : EntityBase
    {
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Avatar { get; set; }
        public ICollection<Status> Statuses { get; set; } 
        public bool InvisibleAvatar { get; set; }
        public string Resume { get; set; }
    }

    public class Status : EntityBase
    {
        public string Body { get; set; }   
    }
}
