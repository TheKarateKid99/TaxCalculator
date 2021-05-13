using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Domain.Interfaces;
using TaxCalculator.Domain.Manager;

namespace TaxCalculator.UnitTestsNew
{
    [TestClass]
    public class TaxCalculator
    {
        [TestInitialize]
       public void Initialize()
        {
           
        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level1_Success()
        {
            //Arrange
            var taxCalculated = new ProgressiveIncomeTax(postalCode: "7441", income: 5000);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level1;

            //Act
            var result = taxCalculated.CalculateProgressiveIncomeTax(progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 500);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level2_Success()
        {
            //Arrange
            var taxCalculated = new ProgressiveIncomeTax(postalCode: "7441", income: 33950);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level2;

            //Act
            var result = taxCalculated.CalculateProgressiveIncomeTax(progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 4675);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level3_Success()
        {
            //Arrange
            var taxCalculated = new ProgressiveIncomeTax(postalCode: "7441", income: 90000);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level3;

            //Act
            var result = taxCalculated.CalculateProgressiveIncomeTax(progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 6612.1);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level4_Success()
        {
            //Arrange
            var taxCalculated = new ProgressiveIncomeTax(postalCode: "7441", income: 150000);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level4;

            //Act
            var result = taxCalculated.CalculateProgressiveIncomeTax(progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 35719.32);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level5_Success()
        {
            //Arrange
            var taxCalculated = new ProgressiveIncomeTax(postalCode: "7441", income: 200000);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level5;

            //Act
            var result = taxCalculated.CalculateProgressiveIncomeTax(progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 51141.49);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level6_Success()
        {
            //Arrange
            var taxCalculated = new ProgressiveIncomeTax(postalCode: "7441", income: 400000);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level6;

            //Act
            var result = taxCalculated.CalculateProgressiveIncomeTax(progressiveTaxTotal);
            //Assert

            Assert.IsTrue(Math.Round(result,2) == 117682.14);

        }
    }
}
