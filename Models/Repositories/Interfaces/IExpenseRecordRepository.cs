using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface IExpenseRecordRepository
    {
        void AddExpenseRecord(ExpenseRecord expenseRecord);
        List<ExpenseRecord> GetExpenseRecords(int UserId);
        ExpenseRecord GetExpenseRecord(int Id);

    }
}
