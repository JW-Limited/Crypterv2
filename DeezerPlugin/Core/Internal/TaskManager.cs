using JWLimited.ApiCollection.Deezer;

namespace DeezerPlugin.Core.Internal
{
    internal class TaskManager
    {
        internal DeezerCredentials _creedentials;
        internal Manager _deezerApiManager = null;
        internal Dictionary<string,Exception> exceptions = new Dictionary<string, Exception>();

        internal TaskManager(DeezerCredentials credentials)
        {
            _creedentials = credentials;
            _deezerApiManager = Manager.Create(credentials, HandleApiError);
        }

        public async void HandleApiError(Exception exception)
        { 
            exceptions.Add(Guid.NewGuid().ToString(),exception);

            if(!await PLuginAPI.Dialogs.ShowErrorMessage(exception))
            {
                Console.WriteLine(exception.ToString());
            }
        }
    }
}
