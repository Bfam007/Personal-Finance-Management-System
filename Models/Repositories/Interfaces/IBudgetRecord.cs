using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface IBudgetRecord
    {
        void AddBudgetRecord(BudgetRecord budgetRecord);
        List<BudgetRecord> GetBudgetRecords();
        BudgetRecord GetBudgetRecord(int UserId);
        BudgetRecord GetBudgRecord(string BudgetRecordName);


    }
}
