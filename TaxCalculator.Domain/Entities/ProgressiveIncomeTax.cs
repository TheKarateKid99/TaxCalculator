using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Domain.TaxLevelsCalculations;

namespace TaxCalculator.Domain.Entities
{
    public class ProgressiveIncomeTax : IncomeTax
    {
       

        public ProgressiveIncomeTax(string postalCode, double income)
            : base(postalCode, income)
        {
           
        }

        public double CalculateProgressiveIncomeTax(ProgressiveTaxLevelEnum progressiveTaxLevel)
        {
            switch (progressiveTaxLevel)
            {
                case ProgressiveTaxLevelEnum.Level1:
                    this.CalculatedAmount = ProgressiveTaxLevel1.CalculatedLevelTaxAmount(Income);
                    return CalculatedAmount;

                case ProgressiveTaxLevelEnum.Level2:
                    this.CalculatedAmount = ProgressiveTaxLevel2.CalculatedLevelTaxAmount(Income);
                    return CalculatedAmount;

                case ProgressiveTaxLevelEnum.Level3:
                    this.CalculatedAmount = ProgressiveTaxLevel3.CalculatedLevelTaxAmount(Income);
                    return CalculatedAmount;

                case ProgressiveTaxLevelEnum.Level4:
                    this.CalculatedAmount = ProgressiveTaxLevel4.CalculatedLevelTaxAmount(Income);
                    return CalculatedAmount;

                case ProgressiveTaxLevelEnum.Level5:
                    this.CalculatedAmount = ProgressiveTaxLevel5.CalculatedLevelTaxAmount(Income);
                    return CalculatedAmount;

                case ProgressiveTaxLevelEnum.Level6:
                    this.CalculatedAmount = ProgressiveTaxLevel6.CalculatedLevelTaxAmount(Income);
                    return CalculatedAmount;

                default:
                    this.CalculatedAmount = 0;
                    return CalculatedAmount;
            }

        }
    }
}
