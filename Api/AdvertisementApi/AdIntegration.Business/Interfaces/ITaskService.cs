using AdIntegration.Data.Entities;

namespace AdIntegration.Business.Interfaces
{
    public interface ITaskService
    {
        public AdminTask CreateAdminTask(AdminTask task);
        public AdminTask UpdateAdminTask(AdminTask task);
        public AdminTask DeleteAdminTask(int id);
        public AdminTask GetAdminTaskById(int id);
        public IEnumerable<AdminTask> GetAdminTasks();
    }
}
