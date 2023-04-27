using AdIntegration.Data;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories
{
    public class UserRepository<T, V> : IUserRepository<T> where T : User where V : Channel<T>
    {
        private readonly ApplicationDbContext<T, V> _context;

        public UserRepository(ApplicationDbContext<T, V> context)
        {
            _context = context;
        }
        /* Create */
        public T AddUser(T user)
        {
            _context.Users.Add(user);
            user.UserId = _context.SaveChanges();
            return user;
        }


        /* Get (Receive) */

        public T GetUserByEmail(string email)
        {
            T user = (T)_context.Users.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                throw new InvalidOperationException();
            }

            return user;
        }

        public IEnumerable<T> GetAllUsers()
        {
            var users = _context.Users.ToList();

            if (users == null)
            {
                return Enumerable.Empty<T>();
            }

            return users as IEnumerable<T>;
        }

        public T GetUserByUsername(string username)
        {
            T user = (T)_context.Users.FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                throw new InvalidOperationException();
            }

            return user;
        }

        public T GetUserById(int id)
        {
            T user = (T)_context.Users.FirstOrDefault(x => x.UserId == id);

            if (user == null)
            {
                throw new InvalidOperationException();
            }

            return user;
        }

        /* Update */
        public object UpdateUser(int userId, T inputUser)
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
        public T DeleteUser(int id)
        {
            var deleteUser = GetUserById(id);
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();

            return deleteUser;
        }

    }
}
