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
            task.Id = _context.SaveChanges();
            return task;
        }

        public AdminTask DeleteTaskById(int id)
        {
            var deleteTask = GetTaskById(id);
            _context.Tasks.Remove(deleteTask);
            _context.SaveChanges();
            return deleteTask;
        }

        public IEnumerable<AdminTask> GetAllTasks()
        {
            var tasks = _context.Tasks.ToList();
            return tasks;
        }

        public AdminTask GetTaskById(int id)
        {
            var foundTask = _context.Tasks.FirstOrDefault(x => x.Id == id);

            if (foundTask == null) 
            {
                throw new InvalidOperationException();
            }

            return foundTask;
        }

        public AdminTask GetTaskByName(string name)
        {
            var foundTask = _context.Tasks.FirstOrDefault(x => x.Name == name);

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

            _context.Tasks.Update(task);
            _context.SaveChanges();

            var response = new
            {
                Old = foundTask,
                New = task
            };

            return response;
        }

        public Comment WriteCommentToTask(AdminTask task, Comment comment)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            comment.Id = task.Id;
            comment.Task = task;

            task.Comments.Add(comment);
            return comment;
        }
    }
}
