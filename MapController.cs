using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Map()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mapp(Login.Models.Map parameters)
        {

            /* var map = new List<double>();
             map.Add(Convert.ToDouble(parameters.latitude));
             map.Add( Convert.ToDouble(parameters.logitude));*/
            ViewBag.lati =parameters.latitude;
            ViewBag.longi =parameters.logitude;

            return View("MapDisplay");
        }
        public ActionResult MapDisplay()
        {
            return View();
        }
    }

}