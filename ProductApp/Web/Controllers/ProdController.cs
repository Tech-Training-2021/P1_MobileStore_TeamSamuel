using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;
using System.Net;

namespace Web.Controllers
{
    public class ProdController : Controller
    {
        // GET: Prod
        ProductRepository repo;
        public ProdController()
        {
            repo = new ProductRepository(new ProductModel());
        }
        // GET: Product
        public ActionResult GetProducts()
        {
            var products = repo.GetProducts();
            var data = new List<Web.Models.Prod>();
            foreach (var c in products)
            {
                data.Add(ProdMapper.Map(c));
            }
            return View(data);
        }
        public ActionResult GetProductsCust()
        {
            var products = repo.GetProducts();
            var data = new List<Web.Models.Prod>();
            foreach (var c in products)
            {
                data.Add(ProdMapper.Map(c));
            }
            return View(data);
        }

        public ActionResult GetProductById(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var product = repo.GetProductById(id);
            if (product == null)
                return HttpNotFound();
            return View(ProdMapper.Map(product));
        }

        [HttpGet]
        public ActionResult Createp()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Createp(Prod pro)
        {
            if (ModelState.IsValid)
            {
                int C_Id = repo.AddCompany(ProdMapper.Mapcomp(pro));
                int S_Id = repo.AddStore(ProdMapper.Mapstor(pro));
                repo.AddProduct(ProdMapper.Mapp(pro),C_Id,S_Id);
                return RedirectToAction("GetProducts");
            }

            return View(pro);
        }
        public ActionResult DeleteProductById(int id)
        {
            var prod = repo.DeleteProductById(id);
            if (prod == null)
                return HttpNotFound();
            return RedirectToAction("GetProducts");
        }
        public ActionResult AddCartProduct(int id)
        {
            string UserName = Session["UserName"].ToString();
            repo.AddCartProduct(id,UserName);
            return RedirectToAction("GetProductsCust");
        }
    }
}