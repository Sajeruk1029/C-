using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace govnotupogogovna.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult govno()
        {
            return View();
        }

        public ActionResult tupugogovna()
        {
            return View();
        }
    }
}