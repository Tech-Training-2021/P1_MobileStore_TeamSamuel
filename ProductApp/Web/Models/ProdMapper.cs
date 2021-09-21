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
        public static Web.Models.Orderhis Map(Data.Entities.OrderH prod)
        {
            return new Web.Models.Orderhis()
            {
                UserName = prod.UserName,
                C_Name = prod.Product.Company.C_Name,
                M_Name = prod.Product.Company.M_Name,
                Ram = prod.Product.Ram,
                Storage = prod.Product.Storage,
                Color = prod.Product.Color,
                Price = prod.Product.Price,
                Locations = prod.Product.Store.Locations,
                Store = prod.Product.Store.S_Name
            };
        }
        public static Data.Entities.Product Mapp(Web.Models.Prod prod)
        {
            return new Data.Entities.Product()
            {
                P_id = prod.P_id,
                Ram = prod.Ram,
                Storage = prod.Storage,
                Color = prod.Color,
                Price = prod.Price
            };
        }
        public static Data.Entities.Company Mapcomp(Web.Models.Prod prod)
        {
            return new Data.Entities.Company()
            {
                    C_Name = prod.C_Name,
                    M_Name = prod.M_Name
            };
        }
        public static Data.Entities.Store Mapstor(Web.Models.Prod prod)
        {
            return new Data.Entities.Store()
            {
                Locations = prod.Locations,
                S_Name = prod.Store
            };
        }
    }
}