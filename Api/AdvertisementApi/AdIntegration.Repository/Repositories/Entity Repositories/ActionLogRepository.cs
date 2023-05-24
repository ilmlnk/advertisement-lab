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

        public ActionLog CreateLog(ActionLog actionLog)
        {
            _context.ActionLogs.Add(actionLog);
            actionLog.Id = _context.SaveChanges();
            return actionLog;
        }

        public ActionLog DeleteLogById(int id)
        {)
            var foundActionLog = GetLogById(id);
            _context.ActionLogs.Remove(foundActionLog);
            _context.SaveChanges();
            return foundActionLog;
        }

        public ActionLog GetLogById(int id)
        {
            var actionLog = _context.ActionLogs.Find(id);

            if (actionLog == null)
            {
                throw new InvalidOperationException();
            }

            return actionLog;
        }

        public IEnumerable<ActionLog> GetActionLogs()
        {
            return _context.ActionLogs.ToList();
        }

    }
}
