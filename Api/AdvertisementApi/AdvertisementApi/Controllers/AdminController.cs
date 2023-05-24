using AdIntegration.Business.Services;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/[controller]")]
public class AdminController : ControllerBase
{
    private readonly AdminService _adminService;
    private readonly ILogger _logger;

    public AdminController(AdminService adminService, ILogger logger)
    {
        _adminService = adminService;
        _logger = logger;
    }


}
