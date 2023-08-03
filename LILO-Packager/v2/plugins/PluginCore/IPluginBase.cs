using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.plugins.PluginCore;
public interface IPluginBase
{
    public String Name
    {
        get; set;
    }
    public String Description
    {
        get; set;
    }

    public ObservableCollection<object> DynamicValues
    {
        get; set;
    }

    public PluginResponse Initialize(PluginParameters args);

    public PluginResponse Execute(PluginParameters args);
}
