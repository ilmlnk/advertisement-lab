using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public User GetUserById(int id);
        public User AddUser(User user);
        public object UpdateUser(int userId, SystemUser inputUser);
        public User DeleteUser(int id);
        public User GetUserByUsername(string username);
    }
}
