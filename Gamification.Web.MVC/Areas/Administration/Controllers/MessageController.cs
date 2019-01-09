using Gamification.Service.Implementing;
using System.Web.Mvc;

namespace Gamification.Web.MVC.Areas.Administration.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
