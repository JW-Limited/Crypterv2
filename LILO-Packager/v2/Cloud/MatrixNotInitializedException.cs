using System.Runtime.Serialization;

namespace LILO_Packager.v2.Cloud
{
    [Serializable]
    internal class MatrixNotInitializedException : Exception
    {
        public MatrixNotInitializedException()
        {
        }

        public MatrixNotInitializedException(string? message) : base(message)
        {
        }

        public MatrixNotInitializedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MatrixNotInitializedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}