namespace LILO_Packager.v2.Core.LILO.Exceptions
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException()
        {
        }

        public InvalidCredentialsException(string message)
            : base(message)
        {
        }

        public InvalidCredentialsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidCredentialsException(string email, string password)
            : this($"The email address '{email}' and password '{password}' do not match.")
        {
        }

        public string Email { get; }
        public string Password { get; }

        public override string Message
        {
            get
            {
                return $"The email address '{Email}' and/or the password '{Password}' do not match. Please check your credentials and try again.";
            }
        }

        public override string ToString()
        {
            return $"Invalid credentials exception: email={Email}, password={Password}";
        }
    }

}
