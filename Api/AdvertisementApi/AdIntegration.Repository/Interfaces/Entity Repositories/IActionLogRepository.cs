using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IActionLogRepository
    {
        public ActionLog CreateLog(int userId, ActionLog action);
        public ActionLog DeleteLogById(int id);
        public ActionLog GetLogById(int id);
        public IEnumerable<ActionLog> GetActionLogs();
    }
}
