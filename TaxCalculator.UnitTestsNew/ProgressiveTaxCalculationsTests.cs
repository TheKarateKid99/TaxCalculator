using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Domain.Enums;
using TaxCalculator.Domain.Interfaces;
using TaxCalculator.Domain.Manager;

namespace TaxCalculator.UnitTestsNew
{
    [TestClass]
    public class TaxCalculator
    {
        private ICalculateIncomeTax _calculateIncomeTax;

        [TestInitialize]
       public void Initialize()
        {
            _calculateIncomeTax = new CalculateIncomeTaxManager();
        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level1_Success()
        {
            //Arrange
            var taxCalculated = new IncomeTax(postalCode: "7441", income: 100);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level1;

            //Act
            var result = _calculateIncomeTax.CalculateProgressiveIncomeTax(taxCalculated.Income,progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 10);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level2_Success()
        {
            //Arrange
            var taxCalculated = new IncomeTax(postalCode: "7441", income: 33950);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level2;

            //Act
            var result = _calculateIncomeTax.CalculateProgressiveIncomeTax(taxCalculated.Income, progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 4675);

        }

        [TestMethod]
        public void Calculate_ProgressiveTax_Level6_Success()
        {
            //Arrange
            var taxCalculated = new IncomeTax(postalCode: "7441", income: 372951);
            var progressiveTaxTotal = ProgressiveTaxLevelEnum.Level6;

            //Act
            var result = _calculateIncomeTax.CalculateProgressiveIncomeTax(taxCalculated.Income, progressiveTaxTotal);
            //Assert

            Assert.IsTrue(result == 4675);

        }
    }
}
