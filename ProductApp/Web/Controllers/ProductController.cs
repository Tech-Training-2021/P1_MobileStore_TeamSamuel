using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        CustomerRepository repo;
        public ProductController()
        {
            repo = new CustomerRepository(new ProductModel());
        }
        // GET: Product
        public ActionResult GetCustomer()
        {
            var customers = repo.GetCustomers();
            var data = new List<Web.Models.Customer>();
            foreach (var c in customers)
            {
                data.Add(Mapper.Map(c));
            }
            return View(data);
        }

        public ActionResult GetCustomerById(int id)
        {
            var customer = repo.GetCustomerById(id);
            return View(Mapper.Map(customer));
        }

        public ActionResult EditCustomer(int id)
        {
            var customer = repo.UpdateCustomer(id);
            return View(Mapper.Map(customer));
        }
    }
}