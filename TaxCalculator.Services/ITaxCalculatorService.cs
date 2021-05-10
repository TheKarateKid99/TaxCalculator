using TaxCalculator.Models;

namespace TaxCalculator.Services
{
    public interface ITaxCalculatorService
    {
        bool CalculateIncomeTax(IncomeTaxDto incomeTaxDto);
    }
}
