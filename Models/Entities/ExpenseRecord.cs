namespace PFMApp.Models.Entities
{
    public class ExpenseRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ExpenseRecordType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Category { get; set; }

    }
}
