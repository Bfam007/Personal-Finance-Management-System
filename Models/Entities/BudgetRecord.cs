namespace PFMApp.Models.Entities
{
    public class BudgetRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BudgetRecordType { get; set; }
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public decimal SavingsGoal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
