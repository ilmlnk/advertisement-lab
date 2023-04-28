using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces
{
    public interface IUserRepository<T> where T : User
    {
        public IEnumerable<T> GetAllUsers();
        public T GetUserById(int id);
        public T AddUser<T>(T user) where T : User;
        public object UpdateUser<T>(int userId, T inputUser) where T : User;
        public T DeleteUser(int id);
        public T GetUserByEmail(string email);
        public T GetUserByUsername(string username);
    }
}
