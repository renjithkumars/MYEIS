using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MVC_test1.Models
{
    public class CustomerContext : DbContext // to establish a connection
    {
        public DbSet <Customer> Customers { get; set; } // Customers object will store all details from database
    }
} 