using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Pages;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ManageCompliancesController : ControllerBase
{
    /*private readonly IManageCompliancesService _compliancesService;

    public ManageCompliancesController(IManageCompliancesService compliancesService)
    {
        _compliancesService = compliancesService;
    }

    public async Task<IActionResult> GetComplianceById(int id)
    {
        throw new Exception();
    }

    public async Task<IActionResult> GetCompliances()
    {
        throw new Exception();
    }

    public async Task<IActionResult> ResolveCompliance()
    {
        throw new Exception();
    }*/
}
