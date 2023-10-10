using LILO_Packager.v2.Plugins.ThirdParty.Types;

namespace LILO_Packager.v2.Plugins.ThirdParty.Interfaces
{
    public interface IPlugin
    {
        Bitmap PluginIcon { get; set; }
        string TempDirectory { get; set; }
        PluginInformation PluginInformation { get; set; }
        string PluginPackageFile { get; set; }
    }

}
