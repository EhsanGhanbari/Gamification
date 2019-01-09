using System.Web.Mvc;
using Gamification.Service.Implementing;

namespace Gamification.Web.MVC.Controllers
{
    public class BillController : BaseController
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        public ActionResult Water()
        {
            return View();
        }

        public ActionResult Power()
        {
            return View();
        }

        public ActionResult Gas()
        {
            return View();
        }

        public ActionResult Phone()
        {
            return View();
        }

        public ActionResult Mobile()
        {
            return View();
        }

    }
}
