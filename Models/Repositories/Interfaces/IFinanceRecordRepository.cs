using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositries.Interfaces
{
    public interface IFinanceRecordRepository
    {
        void AddFinanceRecord(FinanceRecord financeRecord);
        List<FinanceRecord> GetAllFinanceRecords(int UserId);
        FinanceRecord GetFinanceRecord(int Id); 

    }
}
