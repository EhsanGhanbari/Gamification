using System;
using Gamification.Service.DataModel;
using Gamification.Service.Implementing;
using System.Web.Mvc;
using Gamification.Web.MVC.Controllers;

namespace Gamification.Web.MVC.Areas.Administration.Controllers
{
    public class TaskController : BaseAdminController
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public ActionResult List()
        {
            return View("List");
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(TaskView taskView)
        {
            if (!ModelState.IsValid) return View("Create");
            var response = _taskService.CreateTask(taskView);
            return Json(response.Message);
        }

        public ActionResult Update(Guid taskId)
        {
            var task = _taskService.GetTask(taskId);
            return View("Update", task);
        }

        [HttpPost]
        public ActionResult Update(TaskView taskView)
        {
            if (ModelState.IsValid) return View("Update");
            var task = _taskService.UpdateTask(taskView);
            return View("Update", task);
        }

        [HttpPost]
        public ActionResult Delete(Guid taskId)
        {
            var result = _taskService.DeleteTask(taskId);
            return JsonMessage(result.Message);
        }
    }
}
