using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AdIntegration.Business.Services;

public class ActionLogService : IActionLogService
{
    private readonly ActionLogRepository _actionLogRepository;
    private readonly ILogger<ActionLogService> _logger;

    public ActionLogService(ActionLogRepository actionLogRepository, ILogger<ActionLogService> logger)
    {
        _actionLogRepository = actionLogRepository;
        _logger = logger;
    }

    public async Task<ActionLog> CreateLog(int userId, ActionLog actionLog)
    {
        var createdActionLog = _actionLogRepository.CreateLog(actionLog);
        return createdActionLog;
    }

    public async Task<ActionLog> DeleteLogById(int id)
    {
        var deletedActionLog = _actionLogRepository.DeleteLogById(id);
        return deletedActionLog;
    }

    public async Task<ActionLog> GetLogById(int id)
    {
        var actionLog = _actionLogRepository.GetLogById(id);
        return actionLog;
    }

    public async Task<int> GetLogCount()
    {
        var actionLogsCount = await _actionLogRepository.GetActionLogs();
        return actionLogsCount;
    }

    public async Task<IEnumerable<ActionLog>> GetLogList()
    {
        var actionLogs = await _actionLogRepository.GetActionLogs();
        return actionLogs;
    }

    public async Task<IEnumerable<ActionLog>> GetLogListForUser(int userId)
    {
        var actionLogs = await _actionLogRepository.GetLogListForUser(userId);
        return actionLogs;
    }

    public async IEnumerable<ActionLog> GetLogListSinceDate(DateTime date)
    {
        var actionLogs = await _actionLogRepository.GetLogListSinceDate(date);
        return actionLogs;
    }
}
