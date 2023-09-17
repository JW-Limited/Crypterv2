using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;

namespace LILO_Packager.v2.Core
{
    public enum FeatureFlags
    {
        NewEncryptionCore,
        PluginSupport,
        ThirdPartyPluginSupport,
        PluginManager,
        WebView2GraphicalContent,
        SecuredContainerStreaming,
        HistoryElementQuering
    }

    public class FeatureFlagConfig
    {
        public bool NewEncryptionCore { get; set; } = true;
        public bool PluginSupport { get; set; } = true;
        public bool ThirdPartyPluginSupport { get; set; } = false;
        public bool PluginManager { get; set; } = true;
        public bool WebView2GraphicalContent { get; set; } = true;
        public bool SecuredContainerStreaming { get; set; } = true;
        public bool HistoryElementQuering { get; set; } = true;
    }
}
