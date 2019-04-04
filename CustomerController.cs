 using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(Login.Models.Login user)
        {
            

            MyassignmentEntities1 myassignmentEntities = new MyassignmentEntities1();
            if (user.Username == "Anoop")
            {
                var detail = myassignmentEntities.fun_getAllCustomerss().ToList();

                return View(detail);

            }
            var details = myassignmentEntities.fun_getAllCustomerss().Where(a => a.FirstName == user.Username).ToList();

                return View(details);

            
        }
    }
}