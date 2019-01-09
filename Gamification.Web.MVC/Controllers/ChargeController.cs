using System.Web.Mvc;
using Gamification.Service.DataModel;
using Gamification.Service.Implementing;

namespace Gamification.Web.MVC.Controllers
{
    public class ChargeController : BaseController
    {
        private readonly IChargeService _chargeService;

        public ChargeController(IChargeService chargeService)
        {
            _chargeService = chargeService;
        }

        public ActionResult Mci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mci(ChargeView chargeView)
        {
            if (!ModelState.IsValid) return View();
            return View();
        }

        public ActionResult Irancell()
        {
            return View();
        }

        public ActionResult Rightel()
        {
            return View();
        }
    }
}
