using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypterv2.DevTool.Core.Plugins.Types
{
    public class PluginConfig
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Changes { get; set; }
        public string State { get; set; }
        public string PluginIcon { get; set; }
    }
}
