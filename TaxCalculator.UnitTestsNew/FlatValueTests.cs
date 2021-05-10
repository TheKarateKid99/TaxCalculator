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
    public class FlatValueTests
    {
        private ICalculateIncomeTax _calculateIncomeTax;

        [TestInitialize]
        public void Initialize()
        {
            _calculateIncomeTax = new CalculateIncomeTaxManager();
        }

        [TestMethod]
        public void Calculate_FlatValueIncomeTax_UnderMinimumWage_Success()
        {
            //var taxCalculated = new IncomeTax(postalCode: "7441", income: 199999 );

            ////Act
            //var result = _calculateIncomeTax.CalculateFlatValueIncomeTax(taxCalculated.Income);
            ////Assert

            //Assert.IsTrue(result == 9999.95);
        }
        [TestMethod]
        public void Calculate_FlatValueIncomeTax_AboveMinimumWage_Success()
        {
            //var taxCalculated = new IncomeTax(postalCode: "7441", income: 200000);

            ////Act
            //var result = _calculateIncomeTax.CalculateFlatValueIncomeTax(taxCalculated.Income);
            ////Assert

            //Assert.IsTrue(result == 10000);
        }
    }
}
