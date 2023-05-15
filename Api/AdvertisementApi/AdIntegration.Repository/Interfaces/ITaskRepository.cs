using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Repository.Interfaces
{
    public interface ITaskRepository
    {
        public AdminTask CreateTask(AdminTask task);
        public object UpdateTask(int id, AdminTask task);
        public AdminTask DeleteTaskById(int id);
        public AdminTask GetTaskById(int id);
        public AdminTask GetTaskByName(string name);
        public IEnumerable<AdminTask> GetAllTasks();
        public Comment WriteCommentToTask(AdminTask task, Comment comment);
    }
}
