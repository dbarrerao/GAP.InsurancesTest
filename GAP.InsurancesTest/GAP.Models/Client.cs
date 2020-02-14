using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GAP.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Display(Name = "Document")]
        [Required(ErrorMessage = "The Document field is required")]      
        public int Document { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The Name field is required")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "The Age field is required")]
        public int Age { get; set; }
        
        public List<Insurance> Insurance { get; set; }
    }
}
