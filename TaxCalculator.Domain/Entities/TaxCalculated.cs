using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Domain.Entities
{
    public class TaxCalculated
    {

        public TaxCalculated(string postalCode, long income)
        {
            PostalCode = postalCode;
            Income = income;
        }

        public Guid Id { get; private set; }
        public decimal CalculatedAmount { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public string PostalCode { get; private set; }
        public long Income { get; private set; }

        public void CalculateTaxTotla(string postalCode, long income)
        {
            this.CalculatedAmount = 100;
        }
    }
}
