using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities.BaseClass;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Domain.TaxLevelsCalculations;

namespace TaxCalculator.Domain.Entities
{
    public class ProgressiveIncomeTax : IncomeTax
    {
        
        public ProgressiveIncomeTax(string postalCode, long income)
            :base(postalCode,income)
        {
            
        }

        public double CalculateProgressiveIncomeTax(double income, ProgressiveTaxLevelEnum progressiveTaxLevel)
        {
            switch (progressiveTaxLevel)
            {
                case ProgressiveTaxLevelEnum.Level1:
                    return ProgressiveTaxLevel1.CalculatedLevelTaxAmount(income);

                case ProgressiveTaxLevelEnum.Level2:
                    return ProgressiveTaxLevel2.CalculatedLevelTaxAmount(income);

                case ProgressiveTaxLevelEnum.Level3:
                    return ProgressiveTaxLevel3.CalculatedLevelTaxAmount(income);

                case ProgressiveTaxLevelEnum.Level4:
                    return ProgressiveTaxLevel4.CalculatedLevelTaxAmount(income);

                case ProgressiveTaxLevelEnum.Level5:
                    return ProgressiveTaxLevel5.CalculatedLevelTaxAmount(income);

                case ProgressiveTaxLevelEnum.Level6:
                    return ProgressiveTaxLevel6.CalculatedLevelTaxAmount(income);

                default:
                    return 0;

            }

        }
    }
}
