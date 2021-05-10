using System;

namespace TaxCalculator.Domain.Entities.BaseClass
{
    public abstract class IncomeTax
    {

        public IncomeTax(string postalCode, long income)
        {
            PostalCode = postalCode;
            Income = income;
        }

        public  Guid Id { get; private set; }
        public decimal CalculatedAmount { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public string PostalCode { get; private set; }
        public double Income { get; private set; }
    }
}
