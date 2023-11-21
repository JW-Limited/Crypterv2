using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Plugins.ThirdParty.Types
{
    public class PluginDownloadLinks
    {
        private const string GITHUB_BASE_URL = "https://github.com/JW-Limited/Crypterv2/raw/main/PackagedPlugins/";

        public enum Plugin
        { 
            EncLib,
            PlainLib,
            VlcLib,
        }

        public static string Get(Plugin plug)
        {
            if (!_pluginLinks.ContainsKey(plug))
            {
                return $"Plugin '{plug}' does not have a corresponding download link.";
            }

            _pluginLinks.TryGetValue(plug, out string val);
            return val;
        }

        private static readonly Dictionary<Plugin, string> _pluginLinks = new Dictionary<Plugin, string>()
    {
        { Plugin.EncLib, GITHUB_BASE_URL + "CrypterLibrary.cryptex" },
        { Plugin.PlainLib, GITHUB_BASE_URL + "TextPreviewLibrary.cryptex" },
        { Plugin.VlcLib, GITHUB_BASE_URL + "VlcLibrary.cryptex" }, 
    };
    }
}
