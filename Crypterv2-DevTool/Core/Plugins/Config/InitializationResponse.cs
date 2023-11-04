using Crypterv2.DevTool.Core.Contracts;
using Crypterv2.DevTool.Core.Plugins.Types;

namespace Crypterv2.DevTool.Core.Plugins.Config
{
    public class InitializationResponse : ILILOResponse
    {
        public InitializationResponse() { }

        public bool Success { get; set; }
        public string Message { get; set; }
        public uint ErrorCode { get; set; }
        public uint EndCode { get; set; }

        public PluginConfig PluginConfig { get; set; }
        public HashSet<DependencieConfig> Dependencies { get; set; }
        public string PluginIcon { get; set; }
    }
}
