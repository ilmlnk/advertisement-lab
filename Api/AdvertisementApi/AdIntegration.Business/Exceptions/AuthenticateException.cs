using Microsoft.AspNetCore.Http;

namespace AdIntegration.Business.Exceptions;

public class AuthenticateException : Exception, IAppException
{
    public AuthenticateException(string message) : base(message)
    {
    }

    public int GetStatusCode()
    {
        return StatusCodes.Status401Unauthorized;
    }
}
