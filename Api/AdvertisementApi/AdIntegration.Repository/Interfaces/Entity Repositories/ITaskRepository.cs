using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces;

public interface ITaskRepository
{
    public Task<AdminTask> CreateTask(AdminTask task);
    public Task<object> UpdateTask(int id, AdminTask task);
    public Task<AdminTask> DeleteTaskById(int id);
    public Task<AdminTask> GetTaskById(int id);
    public Task<AdminTask> GetTaskByName(string name);
    public Task<IEnumerable<AdminTask>> GetAllTasks();
}
