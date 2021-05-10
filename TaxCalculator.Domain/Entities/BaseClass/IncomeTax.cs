using System;

namespace TaxCalculator.Domain.Entities.BaseClass
{
    public abstract class IncomeTax
    {

        public IncomeTax(string postalCode, double income)
        {
            PostalCode = postalCode;
            Income = income;
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        public  Guid Id { get; private set; }
        public double CalculatedAmount { get; set; }
        public DateTime CreatedDate { get; private set; }

        public string PostalCode { get; private set; }
        public double Income { get; private set; }
    }
}
