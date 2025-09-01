using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositories.Interfaces
{
    public interface IFinancialGoal
    {
        void AddFinancialGoal(FinancialGoal financialGoal);
        List<FinancialGoal> GetFinancialGoal();
        FinancialGoal GetFinancialGoal(string FinancialGoalName);
        FinancialGoal GetFinanacialGoal(int TargetAmount);


    }
}
