using Gamification.Application.BusinessTask;
using Gamification.Service.DataModel;
using log4net;
using System;
using System.Collections.Generic;

namespace Gamification.Service.Implementing
{
    public interface INotificationService
    {
        ResponseBase SendNotification(NotificationView notificationView);
        IList<NotificationView> GetAllNotifications(Guid userId);
        IList<NotificationView> GetAllUnreadNotifications(Guid userId);
        NotificationView GetNotification(Guid notificationId);
    }

    internal class NotificationService : INotificationService
    {
        private readonly INotificationBusiness _notificationBusiness;
        private readonly ILog _log;

        public NotificationService(INotificationBusiness notificationBusiness, ILog log)
        {
            _notificationBusiness = notificationBusiness;
            _log = log;
        }

        public ResponseBase SendNotification(NotificationView notificationView)
        {
            var response = new ResponseBase();

            try
            {
                var notification = notificationView.ToModel();
                _notificationBusiness.Add(notification);
            }
            catch (Exception exception)
            {
                _log.Error(exception.Message);
            }

            return response;
        }

        public IList<NotificationView> GetAllNotifications(Guid userId)
        {
            var notifications = _notificationBusiness.GetAllNotifications();
            return notifications.ToDataModel();
        }

        public IList<NotificationView> GetAllUnreadNotifications(Guid userId)
        {

            var notifications = _notificationBusiness.GetAllUnreadNotifications();
            return notifications.ToDataModel();
        }

        public NotificationView GetNotification(Guid notificationId)
        {
            var notification = _notificationBusiness.GetById(notificationId);
            return notification.ToDataModel();
        }
    }
}
