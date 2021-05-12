using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;

namespace TaxCalculator.Domain.Entities
{
    public class FlatRateIncomeTax : IncomeTax
    {
        public FlatRateIncomeTax(string postalCode, double income)
                   : base(postalCode, income)
        {

        }
        public double CalculateFlatRateIncomeTax()
        {
            CalculatedAmount = Income * FlatRateTaxConstants.TaxPerecntage;
            return CalculatedAmount;
        }
    }
}
