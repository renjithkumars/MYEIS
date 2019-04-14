﻿using Login.Models;
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
             // [HttpPost]
        public JsonResult GetWether(string dta )
        {
            Weather weather = new Weather();
            return Json(weather.getWeather(), JsonRequestBehavior.AllowGet);
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