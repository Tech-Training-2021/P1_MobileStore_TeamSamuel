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
            return db.Products
                    .ToList();
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
            db.Products.Add(prod);
            db.SaveChanges();

        }
        public void AddCartProduct(int id,string UserName)
        {
            //Product pro = (from c in db.Products
             //              where c.P_id == id
               //            select c).FirstOrDefault();
            Product p = new Product();
            p.P_id = id;
            //p.UserName=UserName;
            db.Products.Add(p);
            Save();
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
