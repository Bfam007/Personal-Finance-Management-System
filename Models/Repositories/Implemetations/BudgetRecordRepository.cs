using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class BudgetRecordRepository : IBudgetRecordRepository
    {
        public static List<BudgetRecord> BudgetRecordList = [];
        public void AddBudgetRecord(BudgetRecord budgetRecord)
        {
            BudgetRecordList.Add(budgetRecord);
        }

        public BudgetRecord GetBudgetRecord(int Id)
        {
            var budgetRecord = BudgetRecordList.Where(x => x.Id == Id).FirstOrDefault();
            return budgetRecord;
        }

        public List<BudgetRecord> GetBudgetRecords()
        {
            var budgetRecord = BudgetRecordList.ToList();
            return budgetRecord;
        }

        public BudgetRecord GetBudgRecord(string BudgetRecordName)
        {
            var budgetRecord = BudgetRecordList.Where(x => x.BudgetRecordType== BudgetRecordName).FirstOrDefault();
            return budgetRecord;
        }
    }
}
