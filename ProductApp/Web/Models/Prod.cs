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
        public int P_id { get; set; }

        [Required(ErrorMessage = "Company Name cannot be blank")]
        public string C_Name { get; set; }

        [Required(ErrorMessage = "Mobile Name cannot be blank")]
        public string M_Name { get; set; }

        [Required(ErrorMessage = "Ram cannot be blank")]
        public int Ram { get; set; }

        [Required(ErrorMessage = "Storage cannot be blank")]
        public int Storage { get; set; }

        [Required(ErrorMessage = "Color cannot be blank")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Price cannot be blank")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Location cannot be blank")]
        public string Locations { get; set; }

        [Required(ErrorMessage = "Store Name cannot be blank")]
        public string Store { get; set; }
    }
}