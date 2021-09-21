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
        public int AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            int id = customer.Id;
            return id;
            
        }
        public string DeleteCustomerById(int id)
        {
            Login delog = (from c in db.Logins
                              where c.C_Id == id
                              select c).FirstOrDefault();
            int fid = delog.Id;
            var logn = db.Logins.Find(fid);
            var cust = db.Customers.Find(id);
            if (cust != null && logn != null)
            {
                db.Logins.Remove(logn);
                Save();
                db.Customers.Remove(cust);
                Save();
                return "Removed Sucessfully";
            }
            else
                throw new ArgumentException("Customer not found");
        }
        public Customer UpdateCustomer(Customer cust)
        {

            Customer updatedCust = (from c in db.Customers
                              where c.Id == cust.Id
                              select c).FirstOrDefault();
            updatedCust.F_Name = cust.F_Name;
            updatedCust.L_Name = cust.L_Name;
            updatedCust.Dob = cust.Dob;
            updatedCust.Mobile = cust.Mobile;
            updatedCust.Email = cust.Email;
            updatedCust.Locations = cust.Locations;
            Save();

            return cust;
        }
        public bool CustomerLogin(Login customer)
        {
            Login Checkcust = (from c in db.Logins
                                    where c.UserName == customer.UserName && c.Password == customer.Password
                                    select c).FirstOrDefault();
            if (Checkcust != null)
                return true;
            else
                return false;
        }
        public void AddCustomerL(Login lcustomer,int id)
        {
            lcustomer.C_Id = id;
            db.Logins.Add(lcustomer);
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
        public Customer GetProfile(string Username)
        {
            if (Username != null)
            {
                Login user = (from c in db.Logins
                               where c.UserName == Username
                               select c).FirstOrDefault();
                int? fid = user.C_Id;
                var customer = db.Customers
                    .Where(c => c.Id == fid)
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
