using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
