using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class ExpenseRecortRepository : IExpenseRecordRepository
    {
        public static List<ExpenseRecord> ExpenseRecordList = [];
        public void AddExpenseRecord(ExpenseRecord expenseRecord)
        {
            ExpenseRecordList.Add(expenseRecord);
        }

        public ExpenseRecord GetExpenseRecord(int Id)
        {
            var expenseRecord = ExpenseRecordList.Where(x => x.Id == Id).FirstOrDefault();
            return expenseRecord;
        }

        public List<ExpenseRecord> GetExpenseRecords(int UserId)
        {
            var expenseRecord = ExpenseRecordList.Where(x => x.UserId == UserId).ToList();
            return expenseRecord;

        }


    }
}
