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
    public class TaskController
    {
        private readonly TaskService _taskService;
        public TaskController(TaskService taskService)
        { 
            _taskService = taskService;
        }

        [HttpGet("tasks")]
        public IActionResult GetAllTasks()
        {
            throw new NotImplementedException();
        }

        [HttpGet("task/{id}")]
        public IActionResult GetAdminTaskById(int id) 
        { 
            throw new NotImplementedException();
        }

        [HttpGet("task/create")]
        public IActionResult CreateAdminTask(CreateAdminTaskDto dto)
        {
            throw new NotImplementedException();
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
