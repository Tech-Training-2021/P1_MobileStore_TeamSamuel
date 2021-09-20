using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;
using System.Net;
using Customer = Web.Models.Customer;

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
        public ActionResult DeleteCustomerById(int id)
        {
            var customer = repo.DeleteCustomerById(id);
            if (customer == null)
                return HttpNotFound();
            return RedirectToAction("GetCustomer");
        }

        public ActionResult Createn(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                int C_Id = repo.AddCustomer(Mapper.Map(customer));
                repo.AddCustomerL(Mapper.Maplogin(customer), C_Id);
                return RedirectToAction("GetCustomer");
            }
            
            return View(customer);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var customer = repo.GetCustomerById(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                TempData["Dob"] = customer.Dob;
            }
            return View(Mapper.MapCVM(customer));
        }
        [HttpPost]
        public ActionResult Edit(Customer cust)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateCustomer(Mapper.Map(cust));
                return RedirectToAction("GetCustomer");
            }
            return View(cust);
        }
    }
}