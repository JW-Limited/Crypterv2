using Crypterv2.DevTool.Core.Contracts;
using System.Reflection;

namespace Crypterv2.DevTool.Core.Plugins.Types
{
    public class AssemblyResponse : ILILOResponse
    {
        public uint EndCode { get; set; }
        public uint ErrorCode { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }

        public Assembly LoadedAssembly { get; set; }
        public AssemblyName LoadedAssymblyName { get; set; }
    }
}
