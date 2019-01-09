using Gamification.Service.DataModel;
using Gamification.Service.Implementing;
using Gamification.Web.MVC.Controllers;
using System.Web.Mvc;

namespace Gamification.Web.MVC.Areas.Administration.Controllers
{
    public class AccountController : BaseAdminController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult ChagePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordView changePassword)
        {
            var result = _userService.ChangePassword(changePassword);
            return JsonMessage(result.Message);
        }
    }
}
