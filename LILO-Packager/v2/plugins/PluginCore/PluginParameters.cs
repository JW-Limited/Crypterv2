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
    public HashSet<object> Context { get; set; } = new HashSet<object>();
}
