using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxCalculator.Web.Views.Tax
{
    public class IncomeTaxVM
    {
        public string PostalCode { get; set; }
        public double Income { get; set; }
    }
}
