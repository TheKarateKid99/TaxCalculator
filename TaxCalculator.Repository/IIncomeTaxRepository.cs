using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Repository
{
    public interface IIncomeTaxRepository
    {
        IncomeTax CreateIncomeTax(IncomeTax incomeTax);
    }
}
