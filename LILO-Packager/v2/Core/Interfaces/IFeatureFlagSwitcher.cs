using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface IFeatureFlagSwitcher
    {
        void ToggleFeature(FeatureFlags feature, bool isEnabled);
    }
}
