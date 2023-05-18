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

    public ActionLog CreateLog(ActionLog actionLog)
    {
        var createdActionLog = _actionLogRepository.CreateLog(actionLog);
        _logger.LogInformation("Action Log ");
        return createdActionLog;
    }

    public ActionLog DeleteLogById(int id)
    {
        var deletedActionLog = _actionLogRepository.DeleteLogById(id);
        return deletedActionLog;
    }

    public ActionLog GetLogById(int id)
    {
        var 
    }

    public int GetLogCount()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ActionLog> GetLogList()
    {
        throw new NotImplementedException();
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
