using LILO_Packager.v2.Plugins.PluginCore.UI;

namespace LILO_Packager.v2.Plugins.PluginCore
{
    public interface IPluginBasev3 : IPluginBasev2
    {
        public HostControllableGraphicInterface GraphicInterface { get; set; }
    }
}
