using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdIntegration.Repository.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ApplicationDbContext _context;

    public TaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AdminTask> CreateTask(AdminTask task)
    {
        _context.AdminTasks.Add(task);
        task.Id = await _context.SaveChangesAsync();
        return task;
    }

    public async Task<AdminTask> DeleteTaskById(int id)
    {
        var deleteTask = await GetTaskById(id);

        if (deleteTask != null)
        {
            _context.AdminTasks.Remove(deleteTask);
            await _context.SaveChangesAsync();
        }
        return deleteTask;
    }

    public async Task<IEnumerable<AdminTask>> GetAllTasks()
    {
        var tasks = await _context.AdminTasks.ToListAsync();
        return tasks;
    }

    public async Task<AdminTask> GetTaskById(int id)
    {
        var foundTask = await _context.AdminTasks.FirstOrDefaultAsync(x => x.Id == id);
        return foundTask;
    }

    public async Task<AdminTask> GetTaskByName(string name)
    {
        var foundTask = await _context.AdminTasks.FirstOrDefaultAsync(x => x.Name == name);
        return foundTask;
    }

    public async Task<object> UpdateTask(int id, AdminTask task)
    {
        var foundTask = await GetTaskById(id);
        if (foundTask != null)
        {
            _context.AdminTasks.Update(task);
            await _context.SaveChangesAsync();
        }

        var response = new
        {
            Old = foundTask,
            New = task
        };

        return response;
    }
}
