using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface IUserService
    {
        public User CreateUser(User user);
        public User UpdateUser(int id, User user);
        public int DeleteUserById(int id);
        public IEnumerable<User> GetAllUsers();
        public User GetUserById(int id);
    }
}
