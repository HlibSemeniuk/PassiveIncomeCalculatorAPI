using PassiveIncomeCalculator.Models;

namespace PassiveIncomeCalculator
{
    public class InvestmentCalculatorService
    {
        public double CalculateInvestmentNeeded(UserInput input)
        {
            
                decimal annualPassiveIncome = input.DesiredMonthlyIncome * 12;
                decimal requiredCapital = annualPassiveIncome / input.ConservativeReturnRate;

                // Роки до юажаної пенсії
                int yearsUntilRetirement = input.TargetAge - input.CurrentAge;

                // Розрахунок інфляції за весь період
                decimal inflationFactor = (decimal)Math.Pow((double)(1 + input.InflationRate), yearsUntilRetirement);
                decimal requiredCapitalWithInflation = requiredCapital * inflationFactor;

                // Розрахунок суми, яку потрібно відкладати щорічно
                decimal annualSavingsRequired = requiredCapitalWithInflation /
                    (decimal)((Math.Pow((double)(1 + input.AverageAnnualReturnRate), yearsUntilRetirement) - 1) /
                    (double)input.AverageAnnualReturnRate);

                // Щомісячне інвестування
                decimal monthlyInvestment = annualSavingsRequired / 12;

                // Повертаємо фінальний результат щомісячного інвестування
                return (double)monthlyInvestment;
            
        }
    }
}
