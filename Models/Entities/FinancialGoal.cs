namespace PFMApp.Models.Entities
{
    public class FinancialGoal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FinancialGoalType { get; set; }
        public decimal TargetAmount { get; set; }
        public DateTime Deadline { get; set; }
        public decimal CurrentProgress { get; set; }
        public decimal MonthlyContribution  { get; set; }
    }
}
