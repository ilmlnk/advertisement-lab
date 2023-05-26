using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces;

public interface IActionLogService
{
    public Task<ActionLog> CreateLog(int userId, ActionLog actionLog);
    public Task<ActionLog> DeleteLogById(int id);
    public Task<ActionLog> GetLogById(int id);
    public Task<IEnumerable<ActionLog>> GetLogList();
    public Task<IEnumerable<ActionLog>> GetLogListSinceDate(DateTime date);
    public Task<IEnumerable<ActionLog>> GetLogListForUser(int userId);
    public Task<int> GetLogCount();
}
