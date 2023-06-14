using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Telegram;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories.Telegram;

public class TelegramUserRepository : ITelegramUserRepository
{
    private readonly ApplicationDbContext _context;

    public TelegramUserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TelegramUser> AddTelegramUser(TelegramUser telegramUser)
    {
        await _context.TelegramUsers.AddAsync(telegramUser);
        await _context.SaveChangesAsync();
        return telegramUser;
    }

    public async Task<TelegramUser> DeleteTelegramUserById(int id)
    {
        var foundUser = await GetTelegramUserById(id);

        if (foundUser == null) 
        {
            return foundUser;
        }

        _context.TelegramUsers.Remove(foundUser);
        await _context.SaveChangesAsync();
        return foundUser;
    }

    public async Task<TelegramUser> GetTelegramUserById(int id)
    {
        var foundUser = await _context.TelegramUsers.FindAsync(id);
        return foundUser;
    }

    public async Task<TelegramUser> GetTelegramUserByUsername(string username)
    {
        var foundUser = await _context.TelegramUsers.FirstOrDefaultAsync(u => u.UserName == username);
        return foundUser;
    }

    public async Task<IEnumerable<TelegramUser>> GetTelegramUsers()
    {
        var foundUsers = await _context.TelegramUsers.ToListAsync();
        return foundUsers;
    }

    public async Task<TelegramUser> UpdateTelegramUserById(int id, TelegramUser telegramUser)
    {
        var foundUser = await GetTelegramUserById(id);

        if (foundUser == null)
        {
            return foundUser;
        }

        _context.TelegramUsers.Update(telegramUser);
        await _context.SaveChangesAsync();
        return foundUser;
    }
}
