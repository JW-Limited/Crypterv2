using System.ComponentModel;
using System.Xml.Serialization;

namespace LILO_WebEngine.Core.Handler
{
    public class XMLHandler
    {
        public XMLHandler()
        {
        }

        public static string SerializeToXmlStr<T>(T input, XmlAttributeOverrides attributeOverrides = null)
        {
            var serializer = new XmlSerializer(typeof(T), attributeOverrides);
            using (var writer = new MemoryStream())
            {
                serializer.Serialize(writer, input);
                var byteArray = writer.ToArray();
                return new ByteConverter().ConvertToString(byteArray);
            }
        }

        public static T DeserializeFromString<T>(T output, string xmlstring)
        {
            using (var ms = new MemoryStream(Convert.FromBase64String(xmlstring)))
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Deserialize(ms);
                ms.Position = 0;
                return (T)s.Deserialize(ms);
            }
        }

        public static T DeserializeFromByteArray<T>(T output, byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Deserialize(ms);
                ms.Position = 0;
                return (T)s.Deserialize(ms);
            }
        }

        public static T DeserializeFromStream<T>(T output, Stream byteStream)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            s.Deserialize(byteStream);
            byteStream.Position = 0;
            return (T)s.Deserialize(byteStream);
        }

        public static byte[] SerializeToXmlbA<T>(T input, XmlAttributeOverrides attributeOverrides = null)
        {
            var serializer = new XmlSerializer(typeof(T), attributeOverrides);
            using (var writer = new MemoryStream())
            {
                serializer.Serialize(writer, input);
                return writer.ToArray();
            }
        }
    }
}
