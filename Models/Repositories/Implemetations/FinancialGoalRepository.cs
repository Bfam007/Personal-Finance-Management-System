using PFMApp.Models.Entities;
using PFMApp.Models.Repositories.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class FinancialGoalRepository : IFinancialGoalRepository
    {
        public void AddFinancialGoal(FinancialGoal financialGoal)
        {
            throw new NotImplementedException();
        }

        public FinancialGoal GetFinanacialGoal(decimal TargetAmount)
        {
            throw new NotImplementedException();
        }

        public List<FinancialGoal> GetFinancialGoal()
        {
            throw new NotImplementedException();
        }

        public FinancialGoal GetFinancialGoal(string FinancialGoalName)
        {
            throw new NotImplementedException();
        }
    }
}
