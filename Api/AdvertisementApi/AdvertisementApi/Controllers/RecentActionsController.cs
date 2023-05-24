using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.AdminTaskDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class RecentActionsController : ControllerBase
{
    private readonly ActionLogService _actionLogService;
    private readonly ILogger<RecentActionsController> _logger;
    public RecentActionsController(ActionLogService actionLogService,
        ILogger<RecentActionsController> logger)
    {
        _actionLogService = actionLogService;
        _logger = logger;
    }

    [HttpPost("action/create")]
    public IActionResult CreateLog(int userId, ActionLog action)
    {
        throw new NotImplementedException();
    }

    [HttpGet("action/find/{id}")]
    public IActionResult GetActionLogById(int id)
    {
        var actionLog = _actionLogService.GetLogById(id);

        if (actionLog == null)
        {
            return BadRequest();
        }

        return Ok(actionLog);
    }

    [HttpGet("actions")]
    public IActionResult GetActionLogs()
    {
        var actions = _actionLogService.GetLogList();
        return Ok(actions);
    }

    [HttpDelete("action/delete/{id}")]
    public IActionResult DeleteActionLogById(int id)
    {
        var foundAction = GetActionLogById(id);

        if (foundAction == null) 
        {
            return BadRequest();
        }

        _actionLogService.DeleteLogById(id);
        return Ok(foundAction);
    }

}
