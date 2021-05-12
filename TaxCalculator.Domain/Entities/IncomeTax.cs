using System;
using System.ComponentModel.DataAnnotations;

namespace TaxCalculator.Domain.Entities
{
    public class IncomeTax
    {
        public IncomeTax()
        {
                
        }

        public IncomeTax(string postalCode, double income)
        {
            PostalCode = postalCode;
            Income = income;
            Guid = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; private set; }
        public  Guid Guid { get; private set; }
        public double CalculatedAmount { get; set; }
        public DateTime CreatedDate { get; private set; }

        public string PostalCode { get; private set; }
        public double Income { get; private set; }
    }
}
