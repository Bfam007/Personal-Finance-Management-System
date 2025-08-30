namespace PFMApp.Models.Entities
{
    public class FinanceRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FinanceRecordType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Category { get; set; }

    }
}
