using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Domain.Entities;
using TaxCalculator.Repository;
using TaxCalculator.Services;
using TaxCalculator.Web.Controllers;
using TaxCalculator.Web.Views.Tax;

namespace TaxCalculator.UnitTestsNew.Web
{
    [TestClass]
    public class TaxCalculatorControllerTests
    {
        private MockRepository _mockRepository;
        private IncomeTaxController _controller;
        private ITaxCalculatorService _taxCalculatorService;
        private Mock<IIncomeTaxRepository> _mockIncomeTaxRepository;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockIncomeTaxRepository = _mockRepository.Create<IIncomeTaxRepository>();
            _mockIncomeTaxRepository.Setup(x => x.CreateIncomeTax(It.IsAny<IncomeTax>())).Returns(new IncomeTax());
            _taxCalculatorService = new TaxCalculatorService(_mockIncomeTaxRepository.Object);
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
