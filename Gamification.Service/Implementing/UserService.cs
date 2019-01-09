using Gamification.Application.BusinessTask;
using Gamification.Application.Model;
using Gamification.Service.DataModel;
using log4net;
using System;
using System.Collections.Generic;

namespace Gamification.Service.Implementing
{
    public interface IUserService
    {
        UserView GetUser(Guid userId);
        IList<UserView> GetAllUsers();
        ResponseBase DeleteUser(Guid userId);
        ResponseBase Register(UserView userView);
        ResponseBase UpdateProfile(ProfileView profileView);
        UserView LogIn(LoginView loginView);
        ResponseBase ChangePassword(ChangePasswordView changePasswordView);
        ResponseBase BlockUser(Guid userId);
    }

    internal class UserService : IUserService
    {
        private readonly IUserBusiness _userBusiness;
        //  private readonly ILog _log;

        public UserService(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
            // _log = log;
        }

        public UserView GetUser(Guid userId)
        {
            var user = _userBusiness.GetById(userId);
            return user.ToDataModel();
        }

        public IList<UserView> GetAllUsers()
        {
            var users = _userBusiness.GetAll();
            return users.ToDataModel();
        }

        public ResponseBase DeleteUser(Guid userId)
        {
            var response = new ResponseBase();

            try
            {
                _userBusiness.Remove(userId);
                _userBusiness.SaveChanges();
            }
            catch (Exception exception)
            {
                //  _log.Error(exception.Message);
            }

            return response;
        }

        public ResponseBase Register(UserView userView)
        {
            var response = new ResponseBase();

            try
            {
                var user = userView.ToModel();
                _userBusiness.Register(user.Email, user.Password, user.Mobile);
            }
            catch (Exception exception)
            {
                //  _log.Error(exception.Message);
            }

            return response;
        }

        public ResponseBase UpdateProfile(ProfileView profileView)
        {
            var response = new ResponseBase();

            try
            {
                var profile = profileView.ToModel();
                var user = new User(profile);
                _userBusiness.Update(user);
            }
            catch (Exception exception)
            {
                // _log.Error(exception.Message);
            }

            return response;
        }

        public UserView LogIn(LoginView loginView)
        {
            var user = _userBusiness.LogIn(loginView.Email, loginView.Password);
            return user.ToDataModel();
        }

        public ResponseBase ChangePassword(ChangePasswordView changePasswordView)
        {
            var response = new ResponseBase();

            try
            {
                _userBusiness.ChangePassword(changePasswordView.NewPassword, changePasswordView.OldPassword);
            }
            catch (Exception exception)
            {
                // _log.Error(exception.Message);
            }

            return response;
        }

        public ResponseBase BlockUser(Guid userId)
        {
            var response = new ResponseBase();

            try
            {
                _userBusiness.BlockUser(userId);
            }
            catch (Exception exception)
            {
                // _log.Error(exception.Message);
            }

            return response;
        }
    }
}
