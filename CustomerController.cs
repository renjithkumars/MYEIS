using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Web.Mvc;
using MVC_test1.Models;// This is because the customer class is defined in MVC_test1.Models. 


namespace MVC_test1.Controllers

{

    public class CustomerController : Controller// Customer controller class
    {

        public ActionResult Details(int Id)
        {

            try
            {
                CustomerContext customercontext = new CustomerContext();
                Customer customer = customercontext.Customers.Single(c => c.CustomerId == Id);

                return View(customer);
            }
            catch
            {

                return RedirectToAction("Index1", "Customer");
            }
        }
        public ActionResult Index1()
        {


            CustomerContext customercontext = new CustomerContext();

            List<Customer> customer = customercontext.Customers.ToList();


            return View(customer);


        }
        public ActionResult Index()
        {


            CustomerContext customercontext = new CustomerContext();

            List<Customer> customer = customercontext.Customers.ToList();


            return View(customer);


        }
        public ActionResult Filter(int Did, String Dname)
        {



            CustomerContext customercontext = new CustomerContext();

            List<Customer> customer = customercontext.Customers.Where(c => c.DepartmentId == Did).ToList();



            return View(customer);


        }
    }
}