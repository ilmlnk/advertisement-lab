using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.AdminTaskDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;
        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("tasks")]
        public IActionResult GetAllTasks()
        {
            var tasks = _taskService.GetAdminTasks();
            return Ok(tasks);
        }

        [HttpGet("task/{id}")]
        public IActionResult GetAdminTaskById(int id)
        {
            var task = _taskService.GetAdminTaskById(id);
            return Ok(task);
        }

        [HttpGet("task/create")]
        public IActionResult CreateAdminTask(CreateAdminTaskDto dto)
        {
            var createTask = new AdminTask
            {
                Name = dto.Name,
                Topic = dto.Topic,
                Description = dto.Description,
                Priority = dto.Priority,
            }
        }

        [HttpPut("task/update/{id}")]
        public IActionResult UpdateAdminTask(UpdateAdminTaskDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("task/delete/{id}")]
        public IActionResult DeleteAdminTaskById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
