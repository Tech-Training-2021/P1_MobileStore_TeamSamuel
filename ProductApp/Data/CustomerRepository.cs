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
        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            Save();
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers
                    .ToList();
        }
        public Customer GetCustomerById(int? id)
        {
            if (id > 0)
            {
                var customer = db.Customers
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
                if (customer != null)
                    return customer;
                else
                    return null;
            }
            else
            {
                throw new ArgumentException("Id cannot be less than 0");
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
