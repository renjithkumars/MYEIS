using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_test1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "Canada",
                "US",
                "Enland"
            };
            ViewData["Capitals"] = new List<string>()
            {
                "Ottava",
                "WashingtonDc",
                "London"
            };
            return View();
               
        }
    }
}