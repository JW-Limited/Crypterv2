﻿using LILO_Packager.v2.Plugins.PluginCore;

namespace LILO_Packager.v2.Plugins.Model
{
    public interface IPluginEntry
    {
        string Description { get; set; }
        Form form { get; set; }
        PluginID ID { get; set; }
        string Name { get; set; }
        IPluginBase PluginBase { get; set; }
        string Type { get; set; }
        string Version { get; set; }
    }
}