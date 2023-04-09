using AdIntegration.Business.Models;
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
        public int AddUser(User user);
        public int UpdateUser(int userId, User inputUser);
        public int DeleteUser(int id);
    }
}
