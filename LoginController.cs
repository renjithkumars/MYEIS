﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

            

        [HttpPost]
        public ActionResult Auth(Login.Models.Login usermodel)
        {
            using (MyassignmentEntities1 db = new MyassignmentEntities1())
            {
           // var userdetails = db.Logins.Where(a => a.Username==usermodel.Username && a.Password==usermodel.Password).FirstOrDefault();
               // if (userdetails != null)
                {
                    return RedirectToAction("Index", "Customer","Anoop");
                }
            }
           // return RedirectToAction("Login");
            
        }
    }
}