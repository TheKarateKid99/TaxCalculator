using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Interfaces;

namespace TaxCalculator.Domain.TaxLevelsCalculations
{
    public static class ProgressiveTaxLevel1
    {
        public static double CalculatedLevelTaxAmount(double income)
        {
            var result = income * ProgressiveTaxLevelPercentage.Level1;

            return result;
        }

    }
}
