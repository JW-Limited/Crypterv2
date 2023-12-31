﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Plugins.PluginCore;

public interface IPluginBase
{
    public String Name
    {
        get; set;
    }
    public PluginID ID
    {
        get; set;
    }
    public String Description
    {
        get; set;
    }

    public String Version
    {
        get; set;
    }

    public Form PluginInterface
    {
        get; set;
    }

    public ObservableCollection<object> DynamicValues
    {
        get; set;
    }

    public PluginResponse Initialize(PluginParameters args);

    public PluginResponse Execute(PluginParameters args);

    public PluginResponse Close();
}
