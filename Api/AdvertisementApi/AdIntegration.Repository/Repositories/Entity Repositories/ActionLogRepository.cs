using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories
{
    public class ActionLogRepository : IActionLogRepository
    {
        private readonly ApplicationDbContext _context;

        public ActionLogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionLog> CreateLog(int userId, ActionLog action)
        {
            var createdActionLog = new ActionLog
            {
                UserId = userId,
                ActionName = action.ActionName,
                ActionDescription = action.ActionDescription,
                Timestamp = DateTime.Now
            };

            _context.ActionLogs.Add(createdActionLog);
            await _context.SaveChangesAsync();
            return createdActionLog;
        }

        public async Task<ActionLog> DeleteLogById(int id)
        {
            var foundActionLog = await GetLogById(id);
            if (foundActionLog != null)
            {
                _context.ActionLogs.Remove(foundActionLog);
                await _context.SaveChangesAsync();
            }
            return foundActionLog;
        }

        public async Task<ActionLog> GetLogById(int id)
        {
            var actionLog = await _context.ActionLogs.FindAsync(id);
            return actionLog;
        }

        public async Task<IEnumerable<ActionLog>> GetActionLogs()
        {
            return await _context.ActionLogs
                .ToListAsync();
        }

        public async Task<IEnumerable<ActionLog>> GetLogListForUser(int userId)
        {
            return await _context.ActionLogs
                .Where(log => log.UserId == userId)
                .ToListAsync();
        }
    }
}
