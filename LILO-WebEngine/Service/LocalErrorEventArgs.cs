namespace LILO_WebEngine.Service
{
    public class LocalErrorEventArgs : EventArgs
    {
        public LocalErrorEventArgs(string message)
        {
            Message = message;
        }

        public LocalErrorEventArgs(string message, LocalErrorFatality errorFatality) : this(message)
        {
            ErrorFatality = errorFatality;
        }

        public string Message { get; set; }
        public LocalErrorFatality ErrorFatality { get; set; }
    }
}
