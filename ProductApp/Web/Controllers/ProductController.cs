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

        public ActionResult profile()
        {
            string UserName=Session["UserName"].ToString();
            var customer = repo.GetProfile(UserName);
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
        [HttpGet]
        public ActionResult Createn()
        {
            return View();
        }
        [HttpPost]
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
        public ActionResult Createreg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createreg(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                int C_Id = repo.AddCustomer(Mapper.Map(customer));
                repo.AddCustomerL(Mapper.Maplogin(customer), C_Id);
                return RedirectToAction("Loginn");
            }

            return View(customer);
        }


        public ActionResult Loginn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginn(LoginModel customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.Username == "Admin" && customer.Password == "Admin")
                {
                    Session["UserName"] = customer.Username;
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    bool p = repo.CustomerLogin(Mapper.Maploguser(customer));
                    if (p)
                    {
                        Session["UserName"] = customer.Username;
                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        return RedirectToAction("Loginn");
                    }
                }
            }

            return View();
        }
        public ActionResult userLogout()
        {
            Session.Abandon();
            return RedirectToAction("Loginn");

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
                if (Session["UserName"].ToString() == "Admin")
                {
                    return RedirectToAction("GetCustomer");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(cust);
        }
    }
}