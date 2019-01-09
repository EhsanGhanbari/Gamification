using Gamification.Application.Model;
using Gamification.Service.DataModel;
using System.Collections.Generic;
using System.Linq;

namespace Gamification.Service
{
    public static class MapperExtensions
    {
        #region Bill
        #endregion

        #region Card
        #endregion

        #region Charge

        public static Charge ToModel(this ChargeView chargeView)
        {
            return new Charge
            {

            };
        }

        public static ChargeView ToDataModel(this Charge charge)
        {
            return new ChargeView
            {

            };
        }

        public static IList<ChargeView> ToDataModel(this IList<Charge> charges)
        {
            return charges.Select(c => c.ToDataModel()).ToList();
        }

        #endregion

        #region Darik
        #endregion

        #region Game
        #endregion

        #region Message

        public static Message ToModel(this MessageView messageView)
        {
            return new Message
            {
                Body = messageView.Body,
            };
        }

        public static MessageView ToDataModel(this Message message)
        {
            return new MessageView
            {
                Body = message.Body
            };
        }

        public static IList<MessageView> ToDataModel(this IList<Message> messages)
        {
            return messages.Select(m => m.ToDataModel()).ToList();
        }

        #endregion

        #region Notofication

        public static Notification ToModel(this NotificationView notificationView)
        {
            return new Notification
            {

            };
        }

        public static NotificationView ToDataModel(this Notification notification)
        {
            return new NotificationView
            {

            };
        }

        public static IList<NotificationView> ToDataModel(this IList<Notification> notifications)
        {
            return notifications.Select(n => n.ToDataModel()).ToList();
        }

        #endregion
        
        #region Task

        public static TaskView ToDataModel(this Task task)
        {
            return new TaskView
            {
                TaskId = task.Id,
                Title = task.Title,
                Body = task.Body,
                IsRead = task.IsRead,
                Pending = task.Pending
            };
        }

        public static Task ToModel(this TaskView taskView)
        {
            return new Task
            {
                Title = taskView.Title,
                Body = taskView.Body,
                IsRead = taskView.IsRead,
                Pending = taskView.Pending
            };
        }

        public static IList<TaskView> ToDataModel(this IList<Task> tasks)
        {
            return tasks.Select(t => t.ToDataModel()).ToList();
        }

        #endregion

        #region User

        public static UserView ToDataModel(this User user)
        {
            return new UserView
            {
                Email = user.Email,
                Mobile = user.Mobile,
                Password = user.Password
            };
        }

        public static ProfileView ToDataModel(this Profile profile)
        {
            return new ProfileView
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                NickName = profile.NickName,
                Resume = profile.Resume,
                Avatar = profile.Avatar,
                InvisibleAvatar = profile.InvisibleAvatar,
            };
        }

        public static Profile ToModel(this ProfileView profileView)
        {
            return new Profile
            {
                Avatar = profileView.Avatar,
                FirstName = profileView.FirstName,
                LastName = profileView.LastName,
                NickName = profileView.NickName,
                Resume = profileView.Resume,
                InvisibleAvatar = profileView.InvisibleAvatar
            };
        }

        public static User ToModel(this UserView userView)
        {
            return new User
            {
                Email = userView.Email,
                Mobile = userView.Mobile,
                Password = userView.Password,
            };
        }

        public static IList<UserView> ToDataModel(this IList<User> users)
        {
            return users.Select(u => u.ToDataModel()).ToList();
        }

        #endregion
    }
}
