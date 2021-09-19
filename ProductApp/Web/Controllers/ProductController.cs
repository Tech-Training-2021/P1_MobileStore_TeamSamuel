using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;
using System.Data;
using Customer = Web.Models.Customer;
using System.Net;

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

        public ActionResult GetCustomerById(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var customer = repo.GetCustomerById(id);
            if (customer == null)
                return HttpNotFound();
            return View(Mapper.Map(customer));
        }
    }
}