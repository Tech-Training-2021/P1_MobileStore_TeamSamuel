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
    interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int? P_id);
    }
}
