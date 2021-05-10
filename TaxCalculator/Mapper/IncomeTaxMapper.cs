using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculator.Models;
using TaxCalculator.Web.Views.Tax;

namespace TaxCalculator.Web.Mapper
{
    public static class IncomeTaxMapper
    {
        public static IncomeTaxDto Map(this IncomeTaxVM vm)
        {
            return new IncomeTaxDto(vm.PostalCode,vm.Income);
        }
    }
}
