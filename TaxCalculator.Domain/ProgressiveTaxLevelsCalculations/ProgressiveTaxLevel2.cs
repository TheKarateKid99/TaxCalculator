using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Interfaces;

namespace TaxCalculator.Domain.TaxLevelsCalculations
{
    public static class ProgressiveTaxLevel2
    {
        
        public static double CalculatedLevelTaxAmount(double income)
        {
            var totalRemaining = income;

            //Calculate Level 1
            var level1TaxTotal = ProgressiveTaxLevel1.CalculatedLevelTaxAmount(ProgressiveTaxLevelConstants.Level1Limits);
            totalRemaining -= (ProgressiveTaxLevelConstants.Level1Limits + 1);

            //Calculate Level 2
            var level2TaxTotal = totalRemaining * ProgressiveTaxLevelPercentage.Level2;
            var result = level1TaxTotal + level2TaxTotal;

            return result;
        }

    }
}
