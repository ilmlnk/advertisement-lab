using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;

namespace AdIntegration.Repository.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ApplicationDbContext _context;

    public TaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public AdminTask CreateTask(AdminTask task)
    {
        _context.AdminTasks.Add(task);
        task.Id = _context.SaveChanges();
        return task;
    }

    public AdminTask DeleteTaskById(int id)
    {
        var deleteTask = GetTaskById(id);
        _context.AdminTasks.Remove(deleteTask);
        _context.SaveChanges();
        return deleteTask;
    }

    public IEnumerable<AdminTask> GetAllTasks()
    {
        var tasks = _context.AdminTasks.ToList();
        return tasks;
    }

    public AdminTask GetTaskById(int id)
    {
        var foundTask = _context.AdminTasks.FirstOrDefault(x => x.Id == id);

        if (foundTask == null)
        {
            throw new InvalidOperationException();
        }

        return foundTask;
    }

    public AdminTask GetTaskByName(string name)
    {
        var foundTask = _context.AdminTasks.FirstOrDefault(x => x.Name == name);

        if (foundTask == null)
        {
            throw new InvalidOperationException();
        }

        return foundTask;
    }

    public object UpdateTask(int id, AdminTask task)
    {
        var foundTask = GetTaskById(id);

        if (foundTask == null)
        {
            throw new InvalidOperationException();
        }

        _context.AdminTasks.Update(task);
        _context.SaveChanges();

        var response = new
        {
            Old = foundTask,
            New = task
        };

        return response;
    }
}
