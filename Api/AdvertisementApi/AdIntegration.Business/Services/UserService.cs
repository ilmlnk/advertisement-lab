using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public User GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new InvalidOperationException();
            }
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }

        public int DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
