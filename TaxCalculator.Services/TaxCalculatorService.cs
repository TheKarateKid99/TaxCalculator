using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Constants;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Domain.Interfaces;
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

                if (string.IsNullOrEmpty(incomeTaxDto.PostalCode))
                {
                    return isSuccessful;
                }

                if (incomeTaxDto.Income <= 0)
                {
                    return isSuccessful;
                }

                if (incomeTaxDto.PostalCode == "7441" || incomeTaxDto.PostalCode == "1000")
                {
                    //Calculated Income Tax amount
                    var progressiveTaxLexel = ProgressiveTaxLevel(incomeTaxDto.Income);
                    var incomeTax = new ProgressiveIncomeTax(incomeTaxDto.PostalCode, incomeTaxDto.Income);
                    incomeTax.CalculateProgressiveIncomeTax(progressiveTaxLexel);

                    //Save IncomeTax
                    var result = _incomeTaxRepository.CreateIncomeTax(incomeTax);
                    isSuccessful = result != null;
                    return isSuccessful;
                }

                if (incomeTaxDto.PostalCode == "A100")
                {
                    var incomeTax = new FlatRateIncomeTax(incomeTaxDto.PostalCode, incomeTaxDto.Income);
                    incomeTax.CalculateFlatRateIncomeTax();

                    var result = _incomeTaxRepository.CreateIncomeTax(incomeTax);

                    isSuccessful = result != null;
                }

                if (incomeTaxDto.PostalCode == "7000")
                {
                    var incomeTax = new FlatValueIncomeTax(incomeTaxDto.PostalCode, incomeTaxDto.Income);
                    incomeTax.CalculateFlatValueIncomeTax();

                    var result = _incomeTaxRepository.CreateIncomeTax(incomeTax);

                    isSuccessful = result != null;
                }

                return isSuccessful;
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
