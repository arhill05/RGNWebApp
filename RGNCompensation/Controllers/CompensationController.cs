using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RGNCompensation.Controllers
{
    public class CompensationController : Controller
    {
        // GET: CompensationLog
        public ActionResult Index()
        {
            string url = Url.RouteUrl("DefaultApi", new { httproute = "", controller = "CompensationLog", id = "123" });

            return View();
        }
    }
}