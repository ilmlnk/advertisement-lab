using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace AdIntegration.Repository.Repositories;

public class SystemUserRepository : ISystemUserRepository
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<User> _userManager;

    public SystemUserRepository(ApplicationDbContext context, UserManager<User> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    /* Create */
    public async Task<User> AddUser(User user)
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

    public IEnumerable<SystemUser> GetOnlineUsers()
    {
        var onlineUsers = _context.SystemUsers
            .Where(u => u.IsOnline)
            .ToList();

        return onlineUsers;
    }

    /* Update */
    public object UpdateUser(int userId, SystemUser inputUser)
    {
        var foundUser = _context.Users.Find(userId);

        if (foundUser == null)
        {
            throw new InvalidOperationException();
        }

        _context.SystemUsers.Update(inputUser);
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

        if (deleteUser == null)
        {
            throw new InvalidOperationException();
        }

        _context.Users.Remove(deleteUser);
        _context.SaveChanges();

        return deleteUser;
    }

}
