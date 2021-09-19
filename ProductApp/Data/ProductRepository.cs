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
    }
}
