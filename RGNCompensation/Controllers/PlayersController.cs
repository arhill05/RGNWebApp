using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RGNCompensation.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            string url = Url.RouteUrl("DefaultApi", new { httproute = "", controller = "Players", id = "123" });

            return View();
        }
    }
}