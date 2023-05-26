using AdIntegration.Business.Interfaces;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;

namespace AdIntegration.Business.Services;

public class TaskService : ITaskService
{
    private readonly TaskRepository _taskRepository;

    public TaskService(TaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<AdminTask> CreateAdminTask(AdminTask task)
    {
        var adminTask = await _taskRepository.CreateTask(task);
        return adminTask;
    }

    public async Task<AdminTask> DeleteAdminTask(int id)
    {
        var deleteTask = await _taskRepository.DeleteTaskById(id);
        return deleteTask;
    }

    public async Task<AdminTask> GetAdminTaskById(int id)
    {
        var adminTask = await _taskRepository.GetTaskById(id);
        return adminTask;
    }

    public async Task<IEnumerable<AdminTask>> GetAdminTasks()
    {
        var tasks = await _taskRepository.GetAllTasks();
        return tasks;
    }

    public async Task<object> UpdateAdminTaskById(int id, AdminTask task)
    {
        var updateTask = await _taskRepository.UpdateTask(id, task);
        return updateTask;
    }
}
