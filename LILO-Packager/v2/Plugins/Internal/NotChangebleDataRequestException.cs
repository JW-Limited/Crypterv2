using System.Runtime.Serialization;

namespace LILO_Packager.v2.Plugins.Internal
{
    [Serializable]
    internal class NotChangebleDataRequestException : Exception
    {
        public NotChangebleDataRequestException()
        {
        }

        public NotChangebleDataRequestException(string? message) : base(message)
        {
        }

        public NotChangebleDataRequestException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotChangebleDataRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}