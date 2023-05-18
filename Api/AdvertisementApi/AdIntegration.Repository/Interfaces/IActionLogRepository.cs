using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IActionLogRepository
    {
        public ActionLog CreateLog(ActionLog actionLog);
        public ActionLog DeleteLogById(int id);
        public ActionLog GetLogById(int id);
        public IEnumerable<ActionLog> GetActionLogs();
    }
}
