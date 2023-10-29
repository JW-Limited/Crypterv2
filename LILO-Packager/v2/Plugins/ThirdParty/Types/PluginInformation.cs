using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LILO_Packager.v2.Plugins.ThirdParty.Interfaces;

namespace LILO_Packager.v2.Plugins.ThirdParty.Types
{
    [XmlRoot("Plugin", Namespace = "http://schemas.lilo.com/developer/plugins/2021")]
    public class PluginInformation : IPluginInformation
    {
        [XmlAttribute("Name")]
        public string Name { get; set; } = "Unknown";

        [XmlAttribute("active")]
        public bool Active { get; set; } = true;

        public string PluginDll { get; set; } = "Unknown";

        public VersionInfo Version { get; set; }

        public AuthorInfo Author { get; set; }

        public CompatibilityInfo Compatibility { get; set; }

        public string Description { get; set; } = "Unknown";

        public string Website { get; set; } = "Unknown";

        [XmlElement("License")]
        public LicenseInfo License { get; set; }

        [XmlArray("Dependencies")]
        [XmlArrayItem("Dependency")]
        public List<DependencyInfo> Dependencies { get; set; }

        [XmlArray("Capabilities")]
        [XmlArrayItem("Capability")]
        public List<CapabilityInfo> Capabilities { get; set; }

        public void SerializeToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PluginInformation));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static PluginInformation DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PluginInformation));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (PluginInformation)serializer.Deserialize(reader);
            }
        }
    }

    public class VersionInfo
    {
        [XmlAttribute("Number")]
        public string Number { get; set; } = "0.0.0.1";

        [XmlAttribute("State")]
        public string State { get; set; } = "stable";

        public string ReleaseDate { get; set; } = "Unknown";

        public string Changes { get; set; } = "Unknown";
    }

    public class AuthorInfo
    {
        public string Name { get; set; } = "Unknown";
        public string Company { get; set; } = "Unknown";
    }

    public class CompatibilityInfo
    {
        public WindowsInfo Windows { get; set; }
    }

    public class WindowsInfo
    {
        [XmlAttribute("MinVersion")]
        public string MinVersion { get; set; } = "10.0.0.0";
    }

    public class LicenseInfo
    {
        [XmlAttribute("isNull")]
        public bool IsNull { get; set; } = true;
    }

    public class DependenciesInfo
    {
        public DependencyInfo Dependency { get; set; }
    }

    public class DependencyInfo
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        public VersionInfo Version { get; set; }
        public bool Library { get; set; } = true;
    }


    public class CapabilitiesInfo
    {
        public CapabilityInfo[] Capability { get; set; }
    }

    public class CapabilityInfo
    {
        [XmlAttribute("Name")]
        public string Name { get; set; } = "Unknown";

        public string Description { get; set; } = "Unknown";

        [XmlArray("Arguments")]
        [XmlArrayItem("Argument")]
        public List<ArgumentInfo> Arguments { get; set; }
    }

    public class ArgumentInfo
    {
        [XmlAttribute("Name")]
        public string Name { get; set; } = "Unknown";

        [XmlAttribute("Type")]
        public string Type { get; set; } = "Unknown";
    }
}
