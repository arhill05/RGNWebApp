using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RGNCompensation.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users

        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            string url = Url.RouteUrl("DefaultApi", new { httproute = "", controller = "Users", id = "123" });

            return View();
        }
    }

}