using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;

namespace TaxCalculator.Domain.Entities
{
    public class FlatValueIncomeTax : IncomeTax
    {
        public FlatValueIncomeTax(string postalCode, double income)
                  : base(postalCode, income)
        {

        }
        public double CalculateFlatValueIncomeTax()
        {
            if (Income < FlatVlaueTaxConstants.MinimumWage)
            {
                CalculatedAmount = Income * FlatVlaueTaxConstants.FlatValueRate;
                return CalculatedAmount;
            }
            else
            {
                CalculatedAmount = FlatVlaueTaxConstants.FlatValue;
                return CalculatedAmount;
            }
        }
    }
}
