using LILO_Packager.v2.Plugins.PluginCore.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Plugins.PluginCore
{
    public interface IPluginBasev3 : IPluginBasev2
    {
        public HostControllableGraphicInterface GraphicInterface { get; set; }
    }
}
