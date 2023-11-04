using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypterv2.DevTool.Core.Types
{
    public class PluginFeature
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ArgumentInfo ArgumentInfo { get; set; }
    }
}
