using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LILO_Packager.v2.Core;

namespace LILO_Packager.v2.Core
{
    [Serializable]
    public class FeatureFlagInfo : IFeatureFlagInfo
    {
        public FeatureFlags Feature { get; }
        public bool IsEnabled { get; }

        public FeatureFlagInfo(FeatureFlags feature, bool isEnabled)
        {
            Feature = feature;
            IsEnabled = isEnabled;
        }
    }
}
