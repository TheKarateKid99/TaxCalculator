using System;

namespace TaxCalculator.Models
{
    public class IncomeTaxDto
    {
        
        public IncomeTaxDto(string postalCode, double income)
        {
            PostalCode = postalCode;
            Income = income;
        }

        public string PostalCode { get; private set; }
        public double Income { get; private set; }
    }
}
