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

        public ActionResult GetProductById(int id)
        {
            var product = repo.GetProductById(id);
            return View(ProdMapper.Map(product));
        }
    }
}