using System.Runtime.Serialization;

namespace LILO_Packager.v2.Cloud
{
    [Serializable]
    internal class InvalidMatrixFileExcepion : Exception
    {
        public InvalidMatrixFileExcepion()
        {
        }

        public InvalidMatrixFileExcepion(string? message) : base(message)
        {
        }

        public InvalidMatrixFileExcepion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidMatrixFileExcepion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}