using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LILO_Packager.v2.plugins.PluginCore;

namespace LILO_Packager.v2.plugins.Model;
public class PluginEntry : IPluginEntry
{
    //IDs : Importancy
    //--------------------
    //1: "lvl01.../
    //1: "lvl02...
    //1: "...

    public String Name
    {
        get; set;
    }

    public PluginID ID
    {
        get; set;
    }

    public String Version
    {
        get; set;
    }

    public String Description
    {
        get; set;
    }

    public String Type
    {
        get; set;
    }


    public IPluginBase PluginBase
    {
        get; set;
    }

    IPluginBase plugin = null;

    public Form form
    {
        get;
        set;
    }

    public PluginEntry(IPluginBase p)
    {
        plugin = p;
        this.form = p.PluginInterface;
        this.ID = p.ID;
        this.Name = p.Name;
        this.Description = p.Description;
        this.Version = p.Version;

        var response = plugin.Initialize(null);

        if (response != null)
        {
            if (response.HasError)
            {
                throw new Exception(response.Message + response.MessageID);
            }
            else
            {
                PluginBase = p;

                //form = (UserControl)plugin.DynamicValues[0];
            }
        }

    }
}
