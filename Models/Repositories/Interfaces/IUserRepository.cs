using PFMApp.Models.Entities;

namespace PFMApp.Models.Repositries.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUser(int id);
        User GetUserByEmail(string email);
        List<User> GetUsers();
    }
}
