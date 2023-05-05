using AdIntegration.Data;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace AdIntegration.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public UserRepository(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        /* Create */
        public User AddUser(User user)
        {
            _context.Users.Add(user);
            user.UserId = _context.SaveChanges();
            return user;
        }


        /* Get (Receive) */

        public IEnumerable<User> GetAllUsers()
        {
            var users = _context.Users.ToList();

            if (users == null)
            {
                return Enumerable.Empty<User>();
            }

            return users;
        }

        public User GetUserByUsername(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == username);
            if (user == null)
            {
                return null;
            }

            return user;
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserId == id);

            if (user == null)
            {
                throw new InvalidOperationException();
            }

            return user;
        }

        /* Update */
        public object UpdateUser(int userId, User inputUser)
        {
            var foundUser = _context.Users.Find(userId);

            if (foundUser == null)
            {
                throw new InvalidOperationException();
            }

            _context.Set<User>().Update(inputUser);
            _context.SaveChanges();

            var response = new
            {
                Old = foundUser,
                New = inputUser
            };

            return response;
        }


        /* Delete */
        public User DeleteUser(int id)
        {
            var deleteUser = GetUserById(id);
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();

            return deleteUser;
        }

    }
}
