using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDashborad.Controllers
{
    public class DashboradController : Controller
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
