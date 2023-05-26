using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IActionLogRepository
    {
        public Task<ActionLog> CreateLog(int userId, ActionLog action);
        public Task<ActionLog> DeleteLogById(int id);
        public Task<ActionLog> GetLogById(int id);
        public Task<IEnumerable<ActionLog>> GetActionLogs();
    }
}
