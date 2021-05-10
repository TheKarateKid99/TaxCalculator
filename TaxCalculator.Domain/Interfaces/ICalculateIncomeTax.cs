using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Enums;

namespace TaxCalculator.Domain.Interfaces
{
    public interface ICalculateIncomeTax
    {
        //double CalculateProgressiveIncomeTax(double income, ProgressiveTaxLevelEnum progressiveTaxLevel);
        double CalculateFlatRateIncomeTax(double income);
        double CalculateFlatValueIncomeTax(double income);
    }
}
