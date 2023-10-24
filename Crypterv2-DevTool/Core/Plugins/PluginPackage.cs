using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PluginPackage : PluginEntry
    {
        public PluginPackage(string dllFile,PluginEntry entry,PluginInformation infp, string dir, ObservableCollection<string> Depend) :
            base(entry.PluginBase)
        {
            if (infp != null)
            {
                info = infp;
                PluginDirectory = dir;
                DependencieList = Depend;
            }
            else
            {
                throw new ArgumentNullException(nameof(infp));
            }
        }

        [Required]
        public string DllFile { get; set; }
        [Required]
        public string PluginDirectory { get; set; } = string.Empty;
        [Required]
        public PluginInformation info { get; set; } = null;
        [Required]
        public ObservableCollection<string> DependencieList { get; set; } = new ObservableCollection<string> { string.Empty };
    }
}
