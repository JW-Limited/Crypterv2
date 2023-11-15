using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Contracts
{
    public interface IErrorPageGenerator
    {
        string GenerateErrorPage(HttpStatusCode statusCode, Exception ex = null, string backgroundColor = null, string fontFamily = null);
    }

}
