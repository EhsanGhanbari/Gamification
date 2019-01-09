using System;
using Gamification.Service.Implementing;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace Gamification.Web.MVC.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public ActionResult List()
        {
            var tasks = _taskService.GetAllTasks();
            return View("List", tasks);
        }

        public PartialViewResult Pending()
        {
            var tasks = _taskService.GetAllPendingTasks();
            return PartialView("Pending", tasks);
        }

        public PartialViewResult Detail(Guid taskId)
        {
            var task = _taskService.GetTask(taskId);
            return PartialView("Detail", task);
        }
    }
}
