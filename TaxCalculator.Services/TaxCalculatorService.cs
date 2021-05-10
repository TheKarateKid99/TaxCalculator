using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Models;
using TaxCalculator.Repository;

namespace TaxCalculator.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private readonly IIncomeTaxRepository _incomeTaxRepository;

        public TaxCalculatorService(IIncomeTaxRepository incomeTaxRepository)
        {
            _incomeTaxRepository = incomeTaxRepository;
        }

        public bool CalculateIncomeTax(IncomeTaxDto incomeTaxDto)
        {
            var isSuccessful = false;
            try
            {
                if(incomeTaxDto.PostalCode == "7441" || incomeTaxDto.PostalCode == "1000")
                {
                    var progressiveTaxLexel = ProgressiveTaxLevel(incomeTaxDto.Income);
                    var incomeTax = new ProgressiveIncomeTax(incomeTaxDto.PostalCode, incomeTaxDto.Income);
                    incomeTax.CalculateProgressiveIncomeTax(progressiveTaxLexel);

                    //Save IncomeTax


                    return true;
                }

                return true;
            }
            catch(Exception ex)
            {
                return isSuccessful;
            }
        }

        #region Private Methods

        private ProgressiveTaxLevelEnum ProgressiveTaxLevel(double income)
        {
            if(income <= ProgressiveTaxLevelConstants.Level1Limits)
            {
                return ProgressiveTaxLevelEnum.Level1;
            }

            if (income > ProgressiveTaxLevelConstants.Level1Limits && income <= ProgressiveTaxLevelConstants.Level2Limits)
            {
                return ProgressiveTaxLevelEnum.Level2;
            }

            if (income > ProgressiveTaxLevelConstants.Level2Limits && income <= ProgressiveTaxLevelConstants.Level3Limits)
            {
                return ProgressiveTaxLevelEnum.Level3;
            }

            if (income > ProgressiveTaxLevelConstants.Level3Limits && income <= ProgressiveTaxLevelConstants.Level4Limits)
            {
                return ProgressiveTaxLevelEnum.Level4;
            }

            if (income > ProgressiveTaxLevelConstants.Level4Limits && income <= ProgressiveTaxLevelConstants.Level5Limits)
            {
                return ProgressiveTaxLevelEnum.Level5;
            }

            return ProgressiveTaxLevelEnum.Level6;
        }

        #endregion
    }
}
