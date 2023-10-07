using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Plugins.PluginCore;
public class PluginResponse
{
    public String Message { get; set; } = "";
    public Boolean HasError { get; set; } = false;
    public String MessageID { get; set; } = "";
    public Int32 MESSAGE_UINT { get; set; } = 0x00001;
}
