using SinglePage_24Apr.Models;
using SinglePage_24Apr.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinglePage_24Apr.Controllers
{
    public class SPAController : Controller
    {
        //
        // GET: /SPA/
        public ActionResult Index()
        {
            SpaVM v = new SpaVM();
            v.Customers = GetCust();
            return View(v);
        }

        public ActionResult DataEntry()
        {
            return PartialView();

        }
        public ActionResult SaveCust(Customer cust)
        {
            return Json(cust);
        }
        private List<Customer> GetCust()
        {
            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer();
            c1.CustName = "Cust1";
            c1.Address = "Pune";
            c1.Age = 34;
            customers.Add(c1);

            Customer c2 = new Customer();
            c2.CustName = "Cust2";
            c2.Address = "Pune";
            c2.Age = 28;
            customers.Add(c2);

            Customer c3 = new Customer();
            c3.CustName = "Cust3";
            c3.Address = "Mumbai";
            c3.Age = 25;
            customers.Add(c3);

            Customer c4 = new Customer();
            c4.CustName = "Cust4";
            c4.Address = "KOP";
            c4.Age = 24;
            customers.Add(c4);

            Customer c5 = new Customer();
            c5.CustName = "Cust5";
            c5.Address = "KOP";
            c5.Age = 22;
            customers.Add(c5);

            Customer c6 = new Customer();
            c6.CustName = "Cust6";
            c6.Address = "Mumbai";
            c6.Age = 26;
            customers.Add(c6);

            return customers;

        }
	}
}