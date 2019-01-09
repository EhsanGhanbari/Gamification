using System.Web.Mvc;

namespace Gamification.Web.MVC.Controllers
{
    public class BaseController : Controller
    {
        public JsonResult JsonMessage(string message)
        {
            return Json(new {message}, JsonRequestBehavior.AllowGet);
        }
    }
}
