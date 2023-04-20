using AdIntegration.Business.Models;
using AdIntegration.Data;
using AdIntegration.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            user.UserId = _context.SaveChanges();
            return user;
        }

        public User DeleteUser(int id)
        {
            var deleteUser = GetUserById(id);
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();

            return deleteUser;
        }

        public IEnumerable<User> GetAllUsers() => _context.Users.ToList();

        public User GetUserByEmail(string email) => _context.Users.FirstOrDefault(u => u.Email == email);
        public User GetUserByUsername(string username) => _context.Users.FirstOrDefault(u => u.UserName == username);

        public User GetUserById(int id) => _context.Users.FirstOrDefault(x => x.UserId == id);


        public User UpdateUser(int userId, User inputUser)
        {
            User user = GetUserById(userId);
            _context.Users.Update(inputUser);
            _context.SaveChanges();
            return user;
        }
    }
}
