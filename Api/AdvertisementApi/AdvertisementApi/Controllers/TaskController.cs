using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.AdminTaskDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

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

    [HttpPost("task/create")]
    public IActionResult CreateAdminTask(CreateAdminTaskDto dto)
    {
        var createTask = new AdminTask
        {
            Name = dto.Name,
            Topic = dto.Topic,
            Description = dto.Description,
            Status = dto.Status,
            Priority = dto.Priority,
            CreatedAtDate = dto.CreatedAtDate,
            DueToDate = dto.DueToDate,
            AssignedTo = dto.AssignedTo,
            Tags = dto.Tags,
            Comments = dto.Comments
        };

        var uploadTask = _taskService.CreateAdminTask(createTask);
        return Ok(uploadTask);
    }

    [HttpPut("task/update/{id}")]
    public IActionResult UpdateAdminTask(int id, UpdateAdminTaskDto dto)
    {
        var updateTask = new AdminTask
        {
            Name = dto.Name,
            Topic = dto.Topic,
            Description = dto.Description,
            Status = dto.Status,
            Priority = dto.Priority,
            CreatedAtDate = dto.CreatedAtDate,
            DueToDate = dto.DueToDate,
            AssignedTo = dto.AssignedTo,
            Tags = dto.Tags,
            Comments = dto.Comments
        };

        var uploadTask = _taskService.UpdateAdminTaskById(id, updateTask);
        return Ok(uploadTask);
    }

    [HttpDelete("task/delete/{id}")]
    public IActionResult DeleteAdminTaskById(int id)
    {
        var deleteTask = _taskService.DeleteAdminTask(id);
        return Ok(deleteTask);
    }

}
