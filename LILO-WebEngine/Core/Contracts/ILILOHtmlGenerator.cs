using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Contracts
{
    public interface ILILOHtmlGenerator
    {
        public static ILILOHtmlGenerator Instance { get; }
        public string Generate(string reqDirectory = null, string serverName = null);
        public Task<string> GenerateAsync();
    }
}
