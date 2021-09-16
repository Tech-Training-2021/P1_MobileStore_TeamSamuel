using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Mapper
    {
        public static Web.Models.Customer Map(Data.Entities.Customer customer)
        {
            return new Web.Models.Customer()
            {
                Id = customer.Id,
                F_Name = customer.F_Name,
                L_Name = customer.L_Name,
                Dob = customer.Dob,
                Mobile = customer.Mobile,
                Email = customer.Email,
                Locations = customer.Locations,
            };
        }

    }
}