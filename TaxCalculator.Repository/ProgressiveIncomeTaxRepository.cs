using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;

namespace TaxCalculator.Repository
{
    public class ProgressiveIncomeTaxRepository : Repository<ProgressiveIncomeTax>, IIncomeTaxRepository
    {


        public ProgressiveIncomeTaxRepository(IncomeTaxContext context)
            :base(context)
        {
                
        }
    }
}
