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

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public int DeleteUser(int id)
        {
            _context.Users.Remove(GetUserById(id));
            _context.SaveChanges();
            return id;
        }

        public IEnumerable<User> GetAllUsers() => _context.Users.ToList();

        public User GetUserById(int id) => _context.Users.FirstOrDefault(x => x.Id == id);


        public int UpdateUser(int userId, User inputUser)
        {
            User user = GetUserById(userId);
            _context.Users.Update(inputUser);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
