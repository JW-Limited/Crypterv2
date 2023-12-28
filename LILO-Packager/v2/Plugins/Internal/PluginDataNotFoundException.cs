using System.Runtime.Serialization;

namespace LILO_Packager.v2.Plugins.Internal
{
    [Serializable]
    internal class PluginDataNotFoundException : Exception
    {
        public PluginDataNotFoundException()
        {
        }

        public PluginDataNotFoundException(string? message) : base(message)
        {
        }

        public PluginDataNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PluginDataNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}