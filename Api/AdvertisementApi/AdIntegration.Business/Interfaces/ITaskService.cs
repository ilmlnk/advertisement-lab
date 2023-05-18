using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface ITaskService
    {
        public AdminTask CreateAdminTask(AdminTask task);
        public object UpdateAdminTaskById(int id, AdminTask task);
        public AdminTask DeleteAdminTask(int id);
        public AdminTask GetAdminTaskById(int id);
        public IEnumerable<AdminTask> GetAdminTasks();
    }
}
