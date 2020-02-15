using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GAP.Models
{
    public class Insurance
    {
        
        public int Id { get; set; }

        [Display(Name = "Insurance Name")]
        [Required(ErrorMessage = "The Insurance Name field is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "The Description field is required")]
        public string Description { get; set; }

        [Display(Name = "Validity")]
        [Required(ErrorMessage = "The Validity field is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Period")]
        [Required(ErrorMessage = "The Period field is required")]
        public int Period { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "The Price field is required")]
        public long Price { get; set; }

        [Display(Name = "Covering Type")]
        [Required(ErrorMessage = "The Covering Type field is required")]
        public int CoveringTypeId { get; set; }
       
        public CoveringType CoveringType { get; set; }

        [Display(Name = "Risk Type")]
        [Required(ErrorMessage = "The Risk Type field is required")]
        public int RiskTypeId { get; set; }
        public RiskType RiskType { get; set; }

        [Display(Name = "Client Name")]
        [Required(ErrorMessage = "The Client Name field is required")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
