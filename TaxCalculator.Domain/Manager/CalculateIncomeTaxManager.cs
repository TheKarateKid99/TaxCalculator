using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Domain.Interfaces;
using TaxCalculator.Domain.TaxLevelsCalculations;

namespace TaxCalculator.Domain.Manager
{
    public class CalculateIncomeTaxManager : ICalculateIncomeTaxManager
    {
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

        public double CalculateFlatRateIncomeTax(double income)
        {
            return income * FlatRateTaxConstants.TaxPerecntage;
        }

        public double CalculateFlatValueIncomeTax(double income)
        {
            

            if (income < FlatVlaueTaxConstants.MinimumWage)
            {
                return income * FlatVlaueTaxConstants.FlatValueRate;
            }
            else
            {
                return FlatVlaueTaxConstants.FlatValue;
            }
        }

    }
}
