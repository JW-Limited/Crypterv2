using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LILO_Packager.v2.plugins.PluginCore;

namespace LILO_Packager.v2.plugins.Model;
public class PluginEntry
{
    String Name
    {
    get; set; }

    public String Description
    {
    get; set; }

    public String Type
    {
    get; set; }

    IPluginBase plugin = null;

    public UserControl form { get; set; } = null;

    public PluginEntry(IPluginBase p)
    {
        plugin = p;
        this.Name = p.Name;
        this.Description = p.Description;

        plugin.Initialize(null);
        form = (UserControl)plugin.DynamicValues[0];
    }
}
