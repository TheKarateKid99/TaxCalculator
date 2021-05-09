using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Domain.Interfaces;
using TaxCalculator.Domain.Manager;

namespace TaxCalculator.UnitTestsNew
{
    [TestClass]
    public class FlatRateTests
    {
        private ICalculateIncomeTax _calculateIncomeTax;

        [TestInitialize]
        public void Initialize()
        {
            _calculateIncomeTax = new CalculateIncomeTaxManager();
        }

        [TestMethod]
        public void Calculate_FlatRateIncomeTax_Success()
        {
            var taxCalculated = new IncomeTax(postalCode: "7441", income: 200000);

            //Act
            var result = _calculateIncomeTax.CalculateFlatRateIncomeTax(taxCalculated.Income);
            //Assert

            Assert.IsTrue(result == 35000);
        }
    }
}
