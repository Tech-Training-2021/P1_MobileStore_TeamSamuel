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
        public static Data.Entities.Customer Map(Web.Models.CustomerViewModel customer)
        {
            return new Data.Entities.Customer()
            {
                Id = customer.Id,
                F_Name = customer.F_Name,
                L_Name = customer.L_Name,
                Dob = customer.Dob,
                Mobile = customer.Mobile,
                Email = customer.Email,
                Locations = customer.Locations
            };
        }
        public static Data.Entities.Customer Map(Web.Models.Customer customer)
        {
            return new Data.Entities.Customer()
            {
                Id = customer.Id,
                F_Name = customer.F_Name,
                L_Name = customer.L_Name,
                Dob = customer.Dob,
                Mobile = customer.Mobile,
                Email = customer.Email,
                Locations = customer.Locations
            };
        }
        public static Data.Entities.Login Maplogin(Web.Models.CustomerViewModel lcustomer)
        {
            return new Data.Entities.Login()
            {
                UserName = lcustomer.Username,
                Password = lcustomer.Password,
            };
        }
        public static Data.Entities.Login Maploguser(Web.Models.LoginModel lcustomer)
        {
            return new Data.Entities.Login()
            {
                UserName = lcustomer.Username,
                Password = lcustomer.Password,
            };
        }
        public static Web.Models.Customer MapCVM(Data.Entities.Customer customer)
        {
            return new Web.Models.Customer()
            {
                Id= customer.Id,
                F_Name = customer.F_Name,
                L_Name = customer.L_Name,
                Dob = customer.Dob,
                Mobile = customer.Mobile,
                Email = customer.Email,
                Locations = customer.Locations
            };
        }
    }
}