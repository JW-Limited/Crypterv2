using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LILO_Packager.v2.Core.FeatureFlags Flag { get; set; }
    }
}
