using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.plugins.PluginCore
{
    public interface IPluginInterface
    {
        string Version { get; }
        PluginID Id { get; }
        string Name { get; }

        void Show();
        void Hide();
    }
}
