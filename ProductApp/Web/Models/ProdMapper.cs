using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ProdMapper
    {
        public static Web.Models.Prod Map(Data.Entities.Product prod)
        {
            return new Web.Models.Prod()
            {
                P_id = prod.P_id,
                Ram = prod.Ram,
                Storage = prod.Storage,
                Color = prod.Color,
                Price = prod.Price,
                C_Name = prod.Company.C_Name,
                M_Name = prod.Company.M_Name,
                Locations = prod.Store.Locations,
                Store = prod.Store.S_Name
            };
        }
    }
}