using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LILO_Packager.v2.Core.Flags;

namespace Crypterv2_DevTool.Core
{
    public class FlagInfo
    {
        public FlagInfo() 
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool EnabledState { get; set; }
        public FeatureFlags Flag { get; set; }
    }
}
