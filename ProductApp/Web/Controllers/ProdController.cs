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
        public ActionResult GetOrderHProducts()
        {
            var products = repo.GetOrderHProducts();
            var data = new List<Web.Models.Orderhis>();
            foreach (var c in products)
            {
                data.Add(ProdMapper.Map(c));
            }
            return View(data);
        }
        public ActionResult GetUserOrderHProducts()
        {
            string UserName = Session["UserName"].ToString();
            var products = repo.GetUserOrderHProducts(UserName);
            var data = new List<Web.Models.Orderhis>();
            foreach (var c in products)
            {
                data.Add(ProdMapper.Map(c));
            }
            return View(data);
        }
        public ActionResult GetCartProducts()
        {
            string UserName = Session["UserName"].ToString();
            var carts = repo.GetCartProducts(UserName);
            var data = new List<Web.Models.Prod>();
            foreach (var c in carts)
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
        public ActionResult DeleteCartProductById(int id)
        {
            var prod = repo.DeleteCartProductById(id);
            if (prod == null)
                return HttpNotFound();
            return RedirectToAction("GetCartProducts");
        }
        public ActionResult BuyProductById(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var product = repo.GetProductById(id);
            if (product == null)
                return HttpNotFound();
            return View(ProdMapper.Map(product));
        }
        public ActionResult BuyAllCart(string id)
        {
            id=id.TrimEnd('-');
            List<string> result = id.Split('-').ToList();
            List<int> ids=result.Select(int.Parse).ToList();

           if (ids.Count == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var data = new List<Web.Models.Prod>();
            for (int i=0;i<ids.Count;i++)
            {
                var product = repo.GetProductById(ids[i]);
                if (product == null)
                    return HttpNotFound();
                data.Add(ProdMapper.Map(product));
                
            }
            return View(data);

        }
        public ActionResult PayAllCart(string id)
        {
            id = id.TrimEnd('-');
            List<string> result = id.Split('-').ToList();
            List<int> ids = result.Select(int.Parse).ToList();
            string UserName = Session["UserName"].ToString();
            if (ids.Count == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            for (int i = 0; i < ids.Count; i++)
            {
                repo.AddOrderProduct(ids[i], UserName);
                repo.DeleteCartProductById(ids[i]);

            }
            return RedirectToAction("GetProductsCust");

        }
        public ActionResult Pay(int id)
        {
            string UserName = Session["UserName"].ToString();
            repo.AddOrderProduct(id, UserName);
            repo.DeleteCartProductById(id);
            return RedirectToAction("GetProductsCust");
        }
        public ActionResult AddCartProduct(int id)
        {
            string UserName = Session["UserName"].ToString();
            bool status=repo.AddCartProduct(id,UserName);
            if (status)
            {
                return RedirectToAction("GetProductsCust");
                //Response.Write("<script>alert('Added to the Cart')</script>");
            }
            else
            {
                return RedirectToAction("GetProductsCust");
            }
        }
    }
}