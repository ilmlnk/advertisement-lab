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

    public AdminTask CreateAdminTask(AdminTask task)
    {
        var adminTask = _taskRepository.CreateTask(task);
        return adminTask;
    }

    public AdminTask DeleteAdminTask(int id)
    {
        var deleteTask = _taskRepository.DeleteTaskById(id);
        return deleteTask;
    }

    public AdminTask GetAdminTaskById(int id)
    {
        var adminTask = _taskRepository.GetTaskById(id);
        return adminTask;
    }

    public IEnumerable<AdminTask> GetAdminTasks()
    {
        var tasks = _taskRepository.GetAllTasks();
        return tasks;
    }

    public object UpdateAdminTaskById(int id, AdminTask task)
    {
        var updateTask = _taskRepository.UpdateTask(id, task);
        return updateTask;
    }
}
