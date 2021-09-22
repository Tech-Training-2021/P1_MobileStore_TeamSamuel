using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductRepository : IProduct
    {
        private ProductModel db;
        public ProductRepository(ProductModel db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetProducts()
        {
            var pids = (from c in db.Products
                        where c.Statuss == true
                        select c).OrderBy(a => a.Company.C_Name).ToList();
            return pids;
        }
        public IEnumerable<OrderH> GetOrderHProducts()
        {
            return db.OrderHs.OrderBy(a => a.UserName).ToList();
        }
        public IEnumerable<OrderH> GetUserOrderHProducts(string UserName)
        {
            var pids = (from c in db.OrderHs
                        where c.UserName == UserName
                        select c).ToList();
            return pids;
        }
        public IEnumerable<Product> GetCartProducts(string UserName)
        {
            var pids = (from c in db.Carts
                         where c.UserName == UserName
                         select c.P_id).ToList();
            var a = db.Products.Where(p => pids.Contains(p.P_id));
            return a;

        }
        public Product GetProductById(int? id)
        {
            if (id > 0)
            {
                var prod = db.Products
                    .Where(c => c.P_id == id)
                    .FirstOrDefault();
                if (prod != null)
                    return prod;
                else
                    return null;
            }
            else
            {
                throw new ArgumentException("Id cannot be less than 0");
            }
        }
        public int AddCompany(Company comp)
        {
            db.Companies.Add(comp);
            db.SaveChanges();
            int id = comp.CN_id;
            return id;

        }
        public int AddStore(Store stor)
        {
            db.Stores.Add(stor);
            db.SaveChanges();
            int id = stor.S_id;
            return id;

        }
        public void AddProduct(Product prod,int c_id,int s_id)
        {
            prod.CN_id = c_id;
            prod.S_id = s_id;
            prod.Statuss = true;
            db.Products.Add(prod);
            db.SaveChanges();

        }
        public bool AddCartProduct(int id,string UserName)
        {
            bool status = false;
            var pids = (from c in db.Carts
                        where c.UserName == UserName && c.P_id==id
                        select c.P_id).ToList();
            if (pids.Count == 0)
            {
                Cart co = new Cart();
                co.P_id = id;
                co.UserName = UserName;
                db.Carts.Add(co);
                Save();
                status = true;
            }
            return status;
        }
        public void AddOrderProduct(int id, string UserName)
        {
            OrderH c = new OrderH();
            c.P_id = id;
            c.UserName = UserName;
            db.OrderHs.Add(c);
            Save();
            Product p = db.Products.SingleOrDefault(f => f.P_id == id);
            p.Statuss = false;
            Save();
        }
        public string DeleteCartProductById(int id)
        {
            Cart delcomp = (from c in db.Carts
                               where c.P_id == id
                               select c).FirstOrDefault();
            int f_id = delcomp.A_id;
            var car = db.Carts.Find(f_id);
            if (car != null)
            {
                db.Carts.Remove(car);
                Save();
                return "Removed Sucessfully";
            }
            else
                throw new ArgumentException("Customer not found");
        }

        public string DeleteProductById(int id)
        {
            Company delcomp= (from c in db.Companies
                           where c.CN_id == id
                           select c).FirstOrDefault();
            int c_id = delcomp.CN_id;
            var comp = db.Companies.Find(c_id);
            Store delstor = (from c in db.Stores
                               where c.S_id == id
                               select c).FirstOrDefault();
            int s_id = delstor.S_id;
            var stor = db.Stores.Find(s_id);
            var prod = db.Products.Find(id);
            if (prod != null && comp != null && prod != null)
            {
                db.Products.Remove(prod);
                Save();
                db.Companies.Remove(comp);
                Save();
                db.Stores.Remove(stor);
                Save();
                return "Removed Sucessfully";
            }
            else
                throw new ArgumentException("Customer not found");
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
