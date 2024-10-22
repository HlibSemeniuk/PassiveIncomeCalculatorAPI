using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassiveIncomeCalculator.Models;

namespace PassiveIncomeCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassiveIncomeController : ControllerBase
    {
        private readonly InvestmentCalculatorService _calculatorService;

        public PassiveIncomeController()
        {
            _calculatorService = new InvestmentCalculatorService();

        }

        [HttpPost("calculate")]
        public IActionResult CalculateMonthlyInvestment([FromBody] UserInput input)
        {
            if (input == null)
            {
                return BadRequest("Invalid input data");
            }

            double monthlyInvestment = _calculatorService.CalculateInvestmentNeeded(input);

            return Ok(new { MonthlyInvestment = monthlyInvestment });

        }
    }
}
