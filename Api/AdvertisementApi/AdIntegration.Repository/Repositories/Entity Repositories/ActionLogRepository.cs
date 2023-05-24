using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories
{
    public class ActionLogRepository : IActionLogRepository
    {
        private readonly ApplicationDbContext _context;

        public ActionLogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionLog CreateLog(int userId, ActionLog action)
        {
            var createdActionLog = new ActionLog
            {
                UserId = userId,
                ActionName = action.ActionName,
                ActionDescription = action.ActionDescription,
                Timestamp = DateTime.Now
            };

            _context.ActionLogs.Add(createdActionLog);
            _context.SaveChanges();
            return createdActionLog;
        }

        public ActionLog DeleteLogById(int id)
        {
            var foundActionLog = GetLogById(id);
            _context.ActionLogs.Remove(foundActionLog);
            _context.SaveChanges();
            return foundActionLog;
        }

        public ActionLog GetLogById(int id)
        {
            var actionLog = _context.ActionLogs.Find(id);
            return actionLog;
        }

        public IEnumerable<ActionLog> GetActionLogs()
        {
            return _context.ActionLogs.ToList();
        }

        public IEnumerable<ActionLog> GetLogListForUser(int userId)
        {
            return _context.ActionLogs.Where(log => log.UserId == userId).ToList();
        }
    }
}
