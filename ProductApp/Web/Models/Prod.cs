using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Models
{
    public class Prod
    {
        [HiddenInput]
        [DisplayName("Id")]
        public int P_id { get; set; }

        [Required(ErrorMessage = "Company Name cannot be blank")]
        [DisplayName("Company Name")]
        public string C_Name { get; set; }

        [Required(ErrorMessage = "Mobile Name cannot be blank")]
        [DisplayName("Mobile Name")]
        public string M_Name { get; set; }

        [Required(ErrorMessage = "Ram cannot be blank")]
        [DisplayName("Ram")]
        public int Ram { get; set; }

        [Required(ErrorMessage = "Storage cannot be blank")]
        [DisplayName("Storage")]
        public int Storage { get; set; }

        [Required(ErrorMessage = "Color cannot be blank")]
        [DisplayName("Color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Price cannot be blank")]
        [DisplayName("Price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Location cannot be blank")]
        [DisplayName("Location")]
        public string Locations { get; set; }

        [Required(ErrorMessage = "Store Name cannot be blank")]
        [DisplayName("Store")]
        public string Store { get; set; }
    }
    public class Orderhis
    {
        public int A_id { get; set; }
        public string UserName { get; set; }
        public string C_Name { get; set; }
        public string M_Name { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Locations { get; set; }
        public string Store { get; set; }
    }
}