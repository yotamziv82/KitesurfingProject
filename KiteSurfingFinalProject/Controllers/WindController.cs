using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiteSurfingFinalProject.Controllers
{
    public class WindController : Controller
    {
        // GET: Wind
        public ActionResult GetWind()
        {
            return View("WindView");
        }
    }
}