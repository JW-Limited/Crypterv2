using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.plugins.PluginCore
{
    public class PluginID
    {
        public String ImportancyLevel { get; set; }

        public String Name { get; set; }

        public String Type { get; set; }

        public static PluginID GetID(String name, String type,String Lvl)
        {
            var id = new PluginID();

            if(Lvl is null) id.ImportancyLevel = "";
            else id.ImportancyLevel = Lvl;

            id.Name = name; 
            id.Type = type;

            return id;
        }

        public static string IDtoString(PluginID id)
        {
            string stringID = id.ImportancyLevel+id.Name+id.Type;

            return stringID;
        }
    }
}
