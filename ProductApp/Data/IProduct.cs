﻿using Data.Entities;
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
    interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int? P_id);
        void AddProduct(Product produc,int c_id,int s_id);
        int AddCompany(Company comp);
        string DeleteProductById(int id);
        int AddStore(Store stor);
        void Save();

    }
}
