using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
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

    public ActionLog CreateLog(int userId, ActionLog actionLog)
    {
        var createdActionLog = _actionLogRepository.CreateLog(actionLog);
        return createdActionLog;
    }

    public ActionLog DeleteLogById(int id)
    {
        var deletedActionLog = _actionLogRepository.DeleteLogById(id);
        return deletedActionLog;
    }

    public ActionLog GetLogById(int id)
    {
        var actionLog = _actionLogRepository.GetLogById(id);
        return actionLog;
    }

    public int GetLogCount()
    {
        var actionLogsCount = _actionLogRepository.GetActionLogs().Count();
        return actionLogsCount;
    }

    public IEnumerable<ActionLog> GetLogList()
    {
        var actionLogs = _actionLogRepository.GetActionLogs();
        return actionLogs;
    }

    public IEnumerable<ActionLog> GetLogListForUser(int userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ActionLog> GetLogListSinceDate(DateTime date)
    {
        throw new NotImplementedException();
    }
}
