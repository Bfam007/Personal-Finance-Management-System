namespace PFMApp.Models.Entities
{
    public class ReportsAndAnalyticsRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ReportName { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportType { get; set; }
    }
}
