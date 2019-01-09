using System.Web.Mvc;
using Gamification.Web.MVC.Controllers;

namespace Gamification.Web.MVC.Areas.Administration.Controllers
{
    public class GameController : BaseAdminController
    {
   
        public ActionResult Index()
        {
            return View();
        }

    }
}
