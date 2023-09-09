using LILO_Packager.v2.Core.ColorManager;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.plugins.PluginCore;
public class PluginParameters
{
    public DbConnection con { get; set; } = null;
    public List<object> Context { get; set; } = new List<object>();
    public bool needNewInstance { get; set; } = false;
    public ThemeManager themeManager { get; set; }
}
