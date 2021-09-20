using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name cannot be blank")]
        [StringLength(maximumLength: 50, ErrorMessage = "First Name of the customer should be between 2 to 50 characters", MinimumLength = 2)]
        [DisplayName("First Name")]
        public string F_Name { get; set; }
        [Required(ErrorMessage = "Last Name cannot be blank")]
        [StringLength(maximumLength: 50, ErrorMessage = "Last Name of the customer should be between 2 to 50 characters", MinimumLength = 2)]
        [DisplayName("Last Name")]
        public string L_Name { get; set; }

        [Required(ErrorMessage = "Dob cannot be blank")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Dob")]
        public string Dob { get; set; }
        [Required(ErrorMessage = "Contact cannot be blank")]
        [StringLength(maximumLength: 10, ErrorMessage = "Only 10Digits are allowed", MinimumLength = 10)]
        [DisplayName("Contact")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Email cannot be blank")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Location cannot be blank")]
        [DisplayName("Location")]
        public string Locations { get; set; }
    }
}