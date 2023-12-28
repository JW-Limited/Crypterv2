using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Plugins.Internal
{
    public class PluginData
    {
        public class PermissionSet
        {
            public Permission Permission { get; set; }
            public bool Enabled { get; set; }
        }

        public class PluginStaticValues
        {
            public string Name { get; set; }
            public string LicenseName { get; set; }
            public string LicenseKey { get; set; }
            public DateTime LicensePayDay { get; set; }
            public Boolean Subscription { get; set; }
        }

        public FileFormatClearifier FileFormatClearifier { get; set; } = new FileFormatClearifier()
        {
            ExtensionPrefix = ".pdx",
            FriendlyName = "Plugin Data Extraction",
            SchemeUri = "https://beta.lilo.com/schemes/formater/1",
            FormatVersion = "1.0.2",
            Description = "An extraction of the Plugins Internal Data and Values the using Application generated.",
            DocumentationUri = "null"
        };

        public PluginStaticValues spValues { get; set; }
        public List<PermissionSet> Permissions { get; set; }
        
    }
}
