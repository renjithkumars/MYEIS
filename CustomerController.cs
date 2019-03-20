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
            /* Customer customer= new Customer();// Object of the Customer class
              /*{
                  customer.CustomerId = 1;
                  customer.FirstName = "Rahul";
                  customer.LastName = "Raghu";
                  customer.City = "kochin";
                  customer.Country = "India";
                  customer.Phone = 12345;
              };*/
            try
            {
                CustomerContext customercontext = new CustomerContext();
                Customer customer = customercontext.Customers.Single(c => c.CustomerId == Id);

                /*List<Customer> customer  = customercontext.Customers.ToList();*/


                return View(customer);
            }
            catch
            {

                return RedirectToAction("Index", "Home");
            }
        
        }
    }
}