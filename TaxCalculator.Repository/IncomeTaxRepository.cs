using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Repository
{
    public class IncomeTaxRepository : Repository<IncomeTax>, IIncomeTaxRepository
    {


        public IncomeTaxRepository(IncomeTaxContext context)
            : base(context)
        {

        }

        public IncomeTax CreateIncomeTax(IncomeTax incomeTax)
        {
            var result = Add(incomeTax);
            return result;
        }
    }
}
