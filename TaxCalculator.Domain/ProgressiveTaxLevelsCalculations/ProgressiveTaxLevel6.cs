using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Interfaces;

namespace TaxCalculator.Domain.TaxLevelsCalculations
{
    public static class ProgressiveTaxLevel6
    {
        public static double CalculatedLevelTaxAmount(double income)
        {
            //Calculate Level 1
            var level1TaxTotal = ProgressiveTaxLevel1.CalculatedLevelTaxAmount(ProgressiveTaxLevelConstants.Level1Limits);

            //Calculate Level 2
            var level2TaxTotal = (ProgressiveTaxLevelConstants.Level2Limits - (ProgressiveTaxLevelConstants.Level1Limits + 1)) * ProgressiveTaxLevelPercentage.Level2;

            //Calculate Level 3
            var level3TaxTotal = (ProgressiveTaxLevelConstants.Level3Limits - (ProgressiveTaxLevelConstants.Level2Limits + 1)) * ProgressiveTaxLevelPercentage.Level3;

            //Calculate Level 4
            var level4TaxTotal = (ProgressiveTaxLevelConstants.Level4Limits - (ProgressiveTaxLevelConstants.Level3Limits + 1)) * ProgressiveTaxLevelPercentage.Level4;
           
            //Calculate Level 5
            var level5TaxTotal = (ProgressiveTaxLevelConstants.Level5Limits - (ProgressiveTaxLevelConstants.Level4Limits + 1)) * ProgressiveTaxLevelPercentage.Level5;


            //Calculate Level 5
            var level6Income = income - (ProgressiveTaxLevelConstants.Level5Limits + 1);

            var level6TaxTotal = level6Income * ProgressiveTaxLevelPercentage.Level6;

            var result = level1TaxTotal + level2TaxTotal + level3TaxTotal + level4TaxTotal + level5TaxTotal + level6TaxTotal;

            return result;
        }

    }
}
