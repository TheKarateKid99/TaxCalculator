using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Services;
using TaxCalculator.Web.Controllers;
using TaxCalculator.Web.Views.Tax;

namespace TaxCalculator.UnitTestsNew.Web
{
    [TestClass]
    public class TaxCalculatorControllerTests
    {
        private IncomeTaxController _controller;
        private ITaxCalculatorService _taxCalculatorService;

        [TestInitialize]
        public void Initialize()
        {
            _taxCalculatorService = new TaxCalculatorService();
            _controller = new IncomeTaxController(_taxCalculatorService);
        }

        [TestMethod]
        public void CalculateProgressiveTax_ViaController_Success()
        {
            //Arrange
            var incomeTaxViewModel = new IncomeTaxVM();
            incomeTaxViewModel.Income = 82251;
            incomeTaxViewModel.PostalCode = "7441";

            //Act
            var result = _controller.CalculateIncomeTax(incomeTaxViewModel);

            //Assert
            //Assert.IsTrue(result == true);
        }
    }
}
