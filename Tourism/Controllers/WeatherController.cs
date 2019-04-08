using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public JsonResult GetWether()
        {
            string api = "&APPID=e911d33d2a09374dae45a32724aef3fe&unit=imperial";

            string url = string.Concat("http://api.openweathermap.org/data/2.5/weather?q=", "Dublin", "&APPID=e911d33d2a09374dae45a32724aef3fe&unit=imperial");
            Weather weather = new Weather();
            return Json(weather.getWeather(url), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Weather()
        {

            return View();
        }
        public class Citty
        {
            public string City { get; set; }
        }
    }
}