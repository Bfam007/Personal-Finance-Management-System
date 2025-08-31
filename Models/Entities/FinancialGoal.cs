namespace PFMApp.Models.Entities
{
    public class FinancialGoal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FinancialGoalName { get; set; }
        public decimal TargetAmount { get; set; }
        public DateTime Deadline { get; set; }
        public decimal SavedAmount { get; set; }
        public decimal MonthlyContribution  { get; set; }
    }
}
