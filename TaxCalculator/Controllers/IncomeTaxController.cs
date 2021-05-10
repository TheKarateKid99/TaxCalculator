using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculator.Services;
using TaxCalculator.Web.Mapper;
using TaxCalculator.Web.Views.Tax;

namespace TaxCalculator.Web.Controllers
{
    public class IncomeTaxController : Controller
    {
        private readonly ITaxCalculatorService _taxCalculatorService;

        public IncomeTaxController(ITaxCalculatorService taxCalculatorService)
        {
            _taxCalculatorService = taxCalculatorService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/CalculateIncomeTax")]
        public IActionResult CalculateIncomeTax(IncomeTaxVM incomeTaxVM)
        {

            var result = _taxCalculatorService.CalculateIncomeTax(incomeTaxVM.Map());

            return View(result);
        }
    }
}
