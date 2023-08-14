using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core
{
    public enum FeatureFlags
    {
        NewEncryptionCore,
        PluginSupport,
        ThirdPartyPluginSupport,
        PluginManager,
        WebView2GraphicalContent,
        SecuredContainerStreaming
    }

    public class FeatureFlagePipeLineConfig
    {
        public static string PipeName { get; set; } = "FeatureFlagPipe";
    }

    public class FeatureFlagConfig
    {
        public bool NewEncryptionCore { get; set; } = true;
        public bool PluginSupport { get; set; } = false;
        public bool ThirdPartyPluginSupport { get; set; } = false;
        public bool PluginManager { get; set; } = false;
        public bool WebView2GraphicalContent { get; set; } = false;
        public bool SecuredContainerStreaming { get; set; } = false;

    }
}
