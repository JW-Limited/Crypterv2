using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System.Collections.ObjectModel;

namespace Crypterv2.DevTool.Core.Contracts
{
    public interface ILILOPluginPackage
    {
        string Author { get; set; }
        ObservableCollection<string> DependencieList { get; set; }
        string DllFile { get; set; }
        string IconFile { get; set; }
        PluginInformation info { get; set; }
        string PluginDirectory { get; set; }
    }
}