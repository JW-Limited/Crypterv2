namespace LILO_Packager.v2.Plugins.PluginCore
{
    public class PluginScannerResponse
    {
        public bool PluginsChanged { get; set; }
        public List<ChangedPluginEntry> ChangedPlugins { get; set; } = new List<ChangedPluginEntry> { };
    }
}




