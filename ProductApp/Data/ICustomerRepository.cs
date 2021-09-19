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
        int AddCustomer(Customer customer);
        void AddCustomerL(Login lcustomer,int id);
        void Save();
    }
}
