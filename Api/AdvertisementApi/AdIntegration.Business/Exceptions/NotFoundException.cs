using Microsoft.AspNetCore.Http;

namespace AdIntegration.Business.Exceptions
{
    public class NotFoundException : Exception, IAppException
    {
        public NotFoundException(string message) : base(message)
        {
        }

        public int GetStatusCode()
        {
            return StatusCodes.Status404NotFound;
        }
    }
}
