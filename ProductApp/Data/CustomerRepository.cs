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
    public class CustomerRepository : ICustomerRepository
    {
        private ProductModel db;
        public CustomerRepository(ProductModel db)
        {
            this.db = db;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers
                    .ToList();
        }
    }
}
