using LILO_Packager.v2.Core.Visuals;
using LILO_Packager.v2.Shared.Api.Core;
using System.Data.Common;

namespace LILO_Packager.v2.Plugins.PluginCore;
public class PluginParameters
{
    public DbConnection con { get; set; } = null;
    public List<object> Context { get; set; } = new List<object>();
    public bool needNewInstance { get; set; } = false;
    public ThemeManager themeManager { get; set; }
    public BroadcastChannel Channel = BroadcastChannel.Instance;

}
