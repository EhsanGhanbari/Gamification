using Gamification.Service.Implementing;
using System;
using System.Web.Mvc;

namespace Gamification.Web.MVC.Controllers
{
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public PartialViewResult List()
        {
            var userId = Guid.NewGuid(); //TODO
            var list = _notificationService.GetAllNotifications(userId);
            return PartialView("List", list);
        }

        public PartialViewResult Detail(Guid notificationId)
        {
            var notification = _notificationService.GetNotification(notificationId);
            return PartialView("Detail", notification);
        }
    }
}
