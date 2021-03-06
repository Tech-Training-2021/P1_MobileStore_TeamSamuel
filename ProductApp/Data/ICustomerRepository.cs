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

    interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int? id);
        Customer GetProfile(string Username);

        string DeleteCustomerById(int id);
        Customer UpdateCustomer(Customer cust);
        int AddCustomer(Customer customer);
        bool CustomerLogin(Login customer);
        bool CustomerFpass(string Username,string Password,string email);

        void AddCustomerL(Login lcustomer,int id);
        void Save();
    }
}
