using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxCalculator.Web.Views.Tax
{
    public class IncomeTaxVM
    {
        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal Code required")]
        public string PostalCode { get; set; }
        [Display(Name = "Income")]
        [Required(ErrorMessage = "Income value required")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid income")]
        public double Income { get; set; }

        public bool Response { get; set; }
    }
}
