using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityDemoMVC.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "UserName  is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password  is required")]
        public string UserPassword { get; set; }
    }
}