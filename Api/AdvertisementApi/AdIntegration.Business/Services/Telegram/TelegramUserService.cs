using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Repository.Interfaces.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Services.Telegram;

public class TelegramUserService : ITelegramUserService
{
    private readonly ITelegramUserRepository _userRepository;

    public TelegramUserService(ITelegramUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<TelegramUser> AddTelegramUser(TelegramUser telegramUser)
    {
        var addedUser = await _userRepository.AddTelegramUser(telegramUser);
        return addedUser;
    }

    public async Task<TelegramUser> DeleteTelegramUserById(int id)
    {
        var deletedUser = await _userRepository.DeleteTelegramUserById(id);
        return deletedUser;
    }

    public async Task<TelegramUser> GetTelegramUserById(int id)
    {
        var foundUser = await _userRepository.GetTelegramUserById(id);
        return foundUser;
    }

    public async Task<TelegramUser> GetTelegramUserByUsername(string username)
    {
        var foundUser = await _userRepository.GetTelegramUserByUsername(username);
        return foundUser;
    }

    public async Task<IEnumerable<TelegramUser>> GetTelegramUsers()
    {
        var foundUsers = await _userRepository.GetTelegramUsers();
        return foundUsers;
    }

    public async Task<TelegramUser> UpdateTelegramUserById(int id, TelegramUser telegramUser)
    {
        var updatedUser = await _userRepository.UpdateTelegramUserById(id, telegramUser);
        return updatedUser;
    }
}
