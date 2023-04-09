using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Exceptions
{
    public interface IAppException
    {
        public int GetStatusCode();
    }
}
