namespace Gamification.Service.DataModel
{
    public class UserView
    {
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class ProfileView
    {
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Avatar { get; set; }
        public bool InvisibleAvatar { get; set; }
        public string Resume { get; set; }
        public string Status { get; set; }
    }

    public class LoginView
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class ChangePasswordView
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
