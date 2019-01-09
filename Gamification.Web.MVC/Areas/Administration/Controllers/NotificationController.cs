using System;
using System.Web.Mvc;
using Gamification.Service.DataModel;
using Gamification.Service.Implementing;
using Gamification.Web.MVC.Controllers;

namespace Gamification.Web.MVC.Areas.Administration.Controllers
{
    public class NotificationController : BaseAdminController
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public ActionResult List()
        {
            return View("List");
        }

        public ActionResult Send()
        {
            return View("Send");
        }

        public ActionResult Send(NotificationView notificationView)
        {
            if (ModelState.IsValid) return View("Send");
            var result = _notificationService.SendNotification(notificationView);
            return View("Send");
        }
    }
}
