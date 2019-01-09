using Gamification.Service.Implementing;
using System;
using System.Web.Mvc;

namespace Gamification.Web.MVC.Areas.Administration.Controllers
{
    public class UserController : BaseAdminController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult List()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }

        public ActionResult Detail(Guid userId)
        {
            var user = _userService.GetUser(userId);
            return View(user);
        }

        [HttpPost]
        public JsonResult Block(Guid userId)
        {
            var response = _userService.BlockUser(userId);
            return JsonMessage(response.Message);
        }

        [HttpPost]
        public JsonResult Delete(Guid userId)
        {
            var response = _userService.DeleteUser(userId);
            return JsonMessage(response.Message);
        }
    }
}
