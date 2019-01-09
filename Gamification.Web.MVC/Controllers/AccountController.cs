using Gamification.Service.DataModel;
using System.Web.Mvc;
using Gamification.Service.Implementing;

namespace Gamification.Web.MVC.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logs()
        {
            return View();
        }
        public ActionResult GiftTable()
        {
            return View();
        }

        public ActionResult Daric()
        {
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }

        #region Membership
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(UserView userView)
        {
            if (!ModelState.IsValid) return View("Register");
            var result = _userService.Register(userView);
            return JsonMessage(result.Message);
        }

        public PartialViewResult Login()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Login(LoginView login)
        {
            if (!ModelState.IsValid) return PartialView("Login");
            var result = _userService.LogIn(login);
            return PartialView(result);
        }

        public ActionResult UpdateProfile()
        {
            return View("UpdateProfile");
        }

        [HttpPost]
        public ActionResult UpdateProfile(ProfileView profile)
        {
            if (!ModelState.IsValid) return PartialView("UpdateProfile");
            var result = _userService.UpdateProfile(profile);
            return JsonMessage(result.Message);
        }

        #endregion

    }
}
