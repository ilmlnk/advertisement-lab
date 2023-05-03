using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public User GetUserById(int id);
        public User AddUser(User user);
        public object UpdateUser(int userId, User inputUser);
        public User DeleteUser(int id);
        public User GetUserByEmail(string email);
        public User GetUserByUsername(string username);
    }
}
