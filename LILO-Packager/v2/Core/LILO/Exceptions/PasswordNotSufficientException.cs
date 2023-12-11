using System.Runtime.Serialization;

namespace LILO_Packager.v2.Core.LILO.Exceptions
{
    [Serializable]
    internal class PasswordNotSufficientException : Exception
    {
        public PasswordNotSufficientException()
        {
        }

        public PasswordNotSufficientException(string? message) : base(message)
        {
        }

        public PasswordNotSufficientException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PasswordNotSufficientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}