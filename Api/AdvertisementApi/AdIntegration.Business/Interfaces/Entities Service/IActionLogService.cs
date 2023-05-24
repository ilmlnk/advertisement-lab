using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces;

public interface IActionLogService
{
    public ActionLog CreateLog(int userId, ActionLog actionLog);
    public ActionLog DeleteLogById(int id);
    public ActionLog GetLogById(int id);
    public IEnumerable<ActionLog> GetLogList();
    public IEnumerable<ActionLog> GetLogListSinceDate(DateTime date);
    public IEnumerable<ActionLog> GetLogListForUser(int userId);
    public int GetLogCount();
}
