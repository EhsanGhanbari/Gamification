using System.Web.Mvc;

namespace Gamification.Web.MVC.Controllers
{
    public class DashboradController : BaseController
    {
        //
        // GET: /Dashborad/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserEdit()
        {
            return View();
        }

    }
}
