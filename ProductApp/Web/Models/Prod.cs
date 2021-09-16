using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Prod
    {
        public int P_id { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string C_Name { get; set; }
        public string M_Name{ get; set; }
        public string Locations { get; set; }
        public string Store { get; set; }
    }
}