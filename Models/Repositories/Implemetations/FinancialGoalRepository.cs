using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class FinancialGoalRepository : IFinancialGoalRepository
    {
        public static List<FinancialGoal> FinancialGoalList = [];
        public void AddFinancialGoal(FinancialGoal financialGoal)
        {
            FinancialGoalList.Add(financialGoal);
        }

        public FinancialGoal GetFinanacialGoal(int Id)
        {
            var financialGoal = FinancialGoalList.Where(x => x.Id == Id).FirstOrDefault();
            return financialGoal;
            
        }

        public List<FinancialGoal> GetFinancialGoal()
        {
            var financialGoal = FinancialGoalList.ToList();
            return financialGoal;
        }

        public FinancialGoal GetFinancialGoal(string FinancialGoalName)
        {
            var financialGoal = FinancialGoalList.Where(x => x.FinancialGoalName == FinancialGoalName).FirstOrDefault();
            return financialGoal;
        }
    }
}
