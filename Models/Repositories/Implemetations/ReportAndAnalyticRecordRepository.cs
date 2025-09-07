using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class ReportAndAnalyticRecordRepository: IReportsAndAnalyticsRecordRepository
    {
        public static List<ReportsAndAnalyticsRecord> ReportAndAnalyticRecordList = [];

        public void AddReportsAndAnalyticsRecord(ReportsAndAnalyticsRecord reportAndAnalyticsRecord)
        {
            ReportAndAnalyticRecordList.Add(reportAndAnalyticsRecord);
        }

        public ReportsAndAnalyticsRecord GetReportsAndAnalyticsRecordByName(string ReportName)
        {
            var reportAndAnalyticsRecord = ReportAndAnalyticRecordList.Where(x => x.ReportName == ReportName).FirstOrDefault();
            return reportAndAnalyticsRecord;
        }

        
        public List<ReportsAndAnalyticsRecord> GetReportsAndAnalyticsRecords()
        {
            var reportAndAnalyticsRecord = ReportAndAnalyticRecordList.ToList();
            return reportAndAnalyticsRecord;
        }

        public ReportsAndAnalyticsRecord GetReportsAndAnalyticsRecord(int UserId)
        {
            var reportAndAnalyticsRecord = ReportAndAnalyticRecordList.Where(x => x.UserId == UserId).FirstOrDefault();
            return reportAndAnalyticsRecord;
        }
    }

    
}
