namespace PassiveIncomeCalculator.Models
{
    public class UserInput
    {
        public int CurrentAge { get; set; }
        public int TargetAge { get; set; }
        public decimal DesiredMonthlyIncome { get; set; }
        public decimal ConservativeReturnRate { get; set; }
        public decimal InflationRate { get; set; }
        public decimal AverageAnnualReturnRate { get; set; }
    }
}
