using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface IReportsAndAnalyticsRecordRepository
    {
        void AddReportsAndAnalyticsRecord(ReportsAndAnalyticsRecord reportAndAnalyticsRecord);
        List<ReportsAndAnalyticsRecord> GetReportsAndAnalyticsRecords();
        ReportsAndAnalyticsRecord GetReportsAndAnalyticsRecord(int UserId);
        ReportsAndAnalyticsRecord GetReportsAndAnalyticsRecordByName(string ReportName);
        


    }
}
