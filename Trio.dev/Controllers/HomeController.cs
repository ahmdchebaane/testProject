using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trio.dev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page Priti";
            ViewBag.Title = "Home Page Ahmed";
            ViewBag.Title = "Home Page Priti & Ahmed";
            return View();
        }
    }
}
