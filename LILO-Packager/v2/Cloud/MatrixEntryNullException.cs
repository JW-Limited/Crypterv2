using System.Runtime.Serialization;

namespace LILO_Packager.v2.Cloud
{
    [Serializable]
    internal class MatrixEntryNullException : Exception
    {
        public MatrixEntryNullException()
        {
        }

        public MatrixEntryNullException(string? message) : base(message)
        {
        }

        public MatrixEntryNullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MatrixEntryNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}