using System;

namespace TaxCalculator.Domain.Entities
{
    public class IncomeTax
    {

        public IncomeTax(string postalCode, long income)
        {
            PostalCode = postalCode;
            Income = income;
        }

        private Guid Id { get; set; }
        private decimal CalculatedAmount { get; set; }
        private DateTime CreatedDate { get; set; }

        public string PostalCode { get; private set; }
        public double Income { get; private set; }
    }
}
