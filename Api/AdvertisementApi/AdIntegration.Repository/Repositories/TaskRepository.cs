using AdIntegration.Data;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public AdminTask CreateTask(AdminTask task)
        {
            _context.Tasks.Add(task);
            return task;
        }

        public AdminTask DeleteTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdminTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public AdminTask GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public AdminTask GetTaskByName(string name)
        {
            throw new NotImplementedException();
        }

        public object UpdateTask(AdminTask task)
        {
            throw new NotImplementedException();
        }

        public Comment WriteCommentToTask(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
