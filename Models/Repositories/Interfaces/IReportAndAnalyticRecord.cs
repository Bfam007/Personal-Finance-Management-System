using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface IReportAndAnalyticsRecord
    {
        void AddReportsAndAnalyticsRecord(ReportsAndAnalyticsRecord reportAndAnalyticsRecord);
        List<ReportsAndAnalyticsRecord> GetReportsAndAnalyticsRecords();
        ReportsAndAnalyticsRecord GetReportAndAnalyticsRecord(int UserId);
        ReportsAndAnalyticsRecord GetReportAndAnalyticRecordByName(string ReportName);
        


    }
}
