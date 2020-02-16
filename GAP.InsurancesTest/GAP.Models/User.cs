using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GAP.Models
{
    public class User
    {
        [Display(Name = "User")]
        [Required(ErrorMessage = "The User field is required")]
        public string UserLogin { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The Password field is required")]
        public string Password { get; set; }
    }
}
