using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface IReportAndAnalyticsRecord
    {
        void AddReportAndAnalyticsRecord(ReportAndAnalyticsRecord reportAndAnalyticsRecord);
        List<ReportAndAnalyticsRecord> GetReportAndAnalyticsRecords(int Id);
        ReportAndAnalyticsRecord GetReportAndAnalyticsRecord(int UserId);
        ReportAndAnalyticsRecord GetReportAndAnalyticRecordByName(string ReportName);
        


    }
}
