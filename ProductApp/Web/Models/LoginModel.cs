using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Models
{
    public class LoginModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username cannot be blank")]
        [DisplayName("Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password cannot be blank")]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}