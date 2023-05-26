using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface ITaskService
    {
        public Task<AdminTask> CreateAdminTask(AdminTask task);
        public Task<object> UpdateAdminTaskById(int id, AdminTask task);
        public Task<AdminTask> DeleteAdminTask(int id);
        public Task<AdminTask> GetAdminTaskById(int id);
        public Task<IEnumerable<AdminTask>> GetAdminTasks();
    }
}
