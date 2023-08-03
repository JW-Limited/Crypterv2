﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.plugins.PluginCore;
public class PluginManager
{
    private HashSet<String> DirectoryPaths = new HashSet<string>();
    public HashSet<IPluginBase> CurrentPlugins = new HashSet<IPluginBase>();

    public PluginManager(String DirectoryPath)
    {
        DirectoryPaths.Add(DirectoryPath);
        LoadPlugins();
    }

    public PluginManager(List<String> DirectoryPaths)
    {
        this.DirectoryPaths = new HashSet<string>(DirectoryPaths);
        LoadPlugins();
    }

    public void LoadPlugins()
    {
        CurrentPlugins = new HashSet<IPluginBase>();

        foreach (var ele in DirectoryPaths)
        {
            DirectoryInfo dir = new DirectoryInfo(ele);

            foreach (FileInfo file in dir.GetFiles("*.dll"))
            {
                Assembly ass = Assembly.LoadFrom(file.FullName);
                foreach (Type t in ass.GetTypes())
                {
                    if ((t.IsSubclassOf(typeof(IPluginBase)) || t.GetInterfaces().Contains(typeof(IPluginBase))) && t.IsAbstract == false)
                    {
                        IPluginBase b = t.InvokeMember(null,
                                            BindingFlags.CreateInstance, null, null, null) as IPluginBase;

                        CurrentPlugins.Add(b);
                    }
                }

            }

        }
    }
}
