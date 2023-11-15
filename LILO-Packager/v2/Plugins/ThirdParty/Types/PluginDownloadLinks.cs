using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Plugins.ThirdParty.Types
{
    public class PluginDownloadLinks
    {
        public PluginDownloadLinks() 
        {
        }

        public enum Plugin
        { 
            EncLib,
            PlainLib,
            VlcLib,
        }

        public static string Get(Plugin plug)
        {
            _plugins.TryGetValue(plug, out string val);
            return val ?? "Doesnt contain this Key";
        }

        private static Dictionary<Plugin, string> _plugins = new Dictionary<Plugin, string>() 
        {
            { Plugin.EncLib,   "https://github.com/JW-Limited/Crypterv2/raw/main/PackagedPlugins/CrypterLibrary.cryptex" },
            { Plugin.PlainLib, "https://github.com/JW-Limited/Crypterv2/raw/main/PackagedPlugins/TextPreviewLibrary.cryptex" }
        };
    }
}
