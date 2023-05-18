using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace AdIntegration.Api.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class HealthCheckController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public HealthCheckController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("ping")]
    public IActionResult Get()
    {
        bool isServerAvailable = CheckServerAvailability();

        if (isServerAvailable)
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        else
        {
            return StatusCode(StatusCodes.Status503ServiceUnavailable);
        }
    }

    private bool CheckServerAvailability()
    {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("AdvertisementDb")))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}