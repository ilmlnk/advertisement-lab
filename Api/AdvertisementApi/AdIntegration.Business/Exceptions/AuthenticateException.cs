using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Exceptions
{
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
}
