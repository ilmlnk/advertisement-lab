using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
