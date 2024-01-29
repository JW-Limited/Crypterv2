using System.Runtime.Serialization;

namespace LILO_Packager.v2.Plugins.Internal
{
    [Serializable]
    internal class AccessAlreadyGrantedException : Exception
    {
        public AccessAlreadyGrantedException()
        {
        }

        public AccessAlreadyGrantedException(string? message) : base(message)
        {
        }

        public AccessAlreadyGrantedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AccessAlreadyGrantedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}