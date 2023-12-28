using System.Runtime.Serialization;

namespace LILO_Packager
{
    [Serializable]
    internal class BadInitializeResponse : Exception
    {
        public BadInitializeResponse()
        {
        }

        public BadInitializeResponse(string? message) : base(message)
        {
        }

        public BadInitializeResponse(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BadInitializeResponse(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}