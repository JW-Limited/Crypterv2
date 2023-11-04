using System.Xml;
using System.Xml.Serialization;

namespace Crypterv2.DevTool.Core.Plugins.Config
{
    public class DependencieConfig
    {
        public DevtoolManager DevtoolManager { get; set; }

        [XmlAttribute("IsIndispensible")]
        public bool IsIndispensible { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string FilePath { get; set; }

        public void SerializeToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DependencieConfig));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static DependencieConfig DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DependencieConfig));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (DependencieConfig)serializer.Deserialize(reader);
            }
        }
    }
}
