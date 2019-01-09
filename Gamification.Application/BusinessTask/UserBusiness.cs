using Gamification.Application.Model;
using System;
using Gamification.Shared;

namespace Gamification.Application.BusinessTask
{
    public interface IUserBusiness : IEntityBase<User>
    {
        void Register(string email, string password, string mobile);
        void ChangePassword(string password, string oldPassword);
        User LogIn(string email, string password);
        void BlockUser(Guid userId);
    }

    internal class UserBusiness : EntityBaseBusiness<User>, IUserBusiness
    {
        public void Register(string email, string password, string mobile)
        {
            if (IsEmailTaken(email))
            {
                throw new Exception();
            }

            var user = new User(email, password, mobile);
            user.Password = Cryptography.Encrypt(user.Password);

            base.Add(user);
            base.SaveChanges();
        }

        public void ChangePassword(string password, string oldPassword)
        {
            throw new NotImplementedException();
        }

        public User LogIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void BlockUser(Guid userId)
        {
            var user = SessionFactory.GetCurrentSession().QueryOver<User>().Where(u => u.Id == userId).SingleOrDefault();
            user.IsBlocked = true;
        }

        private static bool IsEmailTaken(string email)
        {
            var isExist = SessionFactory.GetCurrentSession().QueryOver<User>().Where(c => c.Email == email);
            return isExist != null;
        }
    }
}
