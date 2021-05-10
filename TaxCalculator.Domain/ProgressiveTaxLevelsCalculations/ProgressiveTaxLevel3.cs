using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Interfaces;

namespace TaxCalculator.Domain.TaxLevelsCalculations
{
    public static class ProgressiveTaxLevel3
    {
        public static double CalculatedLevelTaxAmount(double income)
        {
 
            //Calculate Level 1
            var level1TaxTotal = ProgressiveTaxLevel1.CalculatedLevelTaxAmount(ProgressiveTaxLevelConstants.Level1Limits);

            //Calculate Level 2
            var level2TaxTotal = (ProgressiveTaxLevelConstants.Level2Limits - (ProgressiveTaxLevelConstants.Level1Limits + 1)) * ProgressiveTaxLevelPercentage.Level2;

            //Calculate Level 3
            var totalRemaining = income - (ProgressiveTaxLevelConstants.Level3Limits + 1);
            var level3TaxTotal = totalRemaining * ProgressiveTaxLevelPercentage.Level3;

            var result = level1TaxTotal + level2TaxTotal + level3TaxTotal;

            return result;
        }

    }
}
