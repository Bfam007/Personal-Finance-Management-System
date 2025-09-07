using PFMApp.Models.Entities;
using PFMApp.Models.Repositries.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class FinanceRecordRepository : IFinanceRecordRepository
    {
        public static List<FinanceRecord> FinanceRecordList = [];
        public void AddFinanceRecord(FinanceRecord financeRecord)
        {
            FinanceRecordList.Add(financeRecord);
        }

        public List<FinanceRecord> GetAllFinanceRecords()
        {
            var financeRecord = FinanceRecordList.ToList();
            return financeRecord;
        }

        public FinanceRecord GetFinanceRecord(int Id)
        {
            var financeRecord = FinanceRecordList.Where(x => x.Id == Id).FirstOrDefault();
            return financeRecord;
        }
    }
}
