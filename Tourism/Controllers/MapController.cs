using Login.Models;
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

        
        public ActionResult Mapp(string id)
        {
            int Id=( Convert.ToInt32(id)); 
             MyassignmentEntities myassignmentEntities = new MyassignmentEntities();

            var details =myassignmentEntities.fun_getLocations().Where(a => a.Id == Id).ToList();
            

            return View(details);
        }
       
    }

}