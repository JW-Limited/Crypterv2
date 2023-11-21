using System.ComponentModel;

namespace LILO_Packager.v2.Plugins.PluginCore
{
    public enum ChangedState
    {
        [Description("Plugin has been removed.")]
        Removed,

        [Description("Plugin has been updated to a newer version.")]
        Updated,

        [Description("Plugin has been added to the plugin list.")]
        Added,

        [Description("Plugin information has changed.")]
        Changed
    }
}




