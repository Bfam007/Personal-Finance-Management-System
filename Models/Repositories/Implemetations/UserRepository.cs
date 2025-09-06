using PFMApp.Models.Entities;
using PFMApp.Models.Repositries.Interfaces;

namespace PFMApp.Models.Repositories.Implemetations
{
    public class UserRepository : IUserRepository
    {
        public static List<User> UserList = [];
        public void AddUser(User user)
        {
            UserList.Add(user);
        }

        public User GetUser(int id)
        {
            var user = UserList.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }

        public User GetUserByEmail(string email)
        {
            var user = UserList.Where(x => x.Email == email).FirstOrDefault();
            return user;
        }

        public List<User> GetUsers()
        {
            var users = UserList.ToList();
            return users;
        }
    }
}
