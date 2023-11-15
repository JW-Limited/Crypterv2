using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Local.Types;
using LILO_WebEngine.Service;
using LILO_WebEngine.Shared;

namespace LILO_WebEngine.Core.Handler
{
    public class EngineEventHandler
    {
        private static Lazy<EngineEventHandler> _lazyInstance = new Lazy<EngineEventHandler>(() => new EngineEventHandler());
        public static EngineEventHandler Instance => _lazyInstance.Value;
        private List<WEB_ENGINE_EVENT> _EVENTs = new List<WEB_ENGINE_EVENT>();
        public List<Exception> Exceptions = new List<Exception>();
        public List<WEB_ENGINE_EVENT> WebEngineEvents => _EVENTs;

        private EngineEventHandler()
        {

        }

        public void AddEvent(WEB_ENGINE_EVENT webEngineEvent)
        {
            ArgumentNullException.ThrowIfNull(webEngineEvent, nameof(webEngineEvent));
            try
            {
                webEngineEvent.EventToken = new Tokenizer(24, 6).GenerateRandomToken();
                _EVENTs.Add(webEngineEvent);
            }
            catch (Exception ex)
            {
                Exceptions.Add(ex);
                throw;
            }
        }

        public void AddEvent(string message, object? handle)
        {
            ArgumentNullException.ThrowIfNull(message, nameof(message));
            var webEngineEvent = new WEB_ENGINE_EVENT();
            webEngineEvent.Description = message;
            webEngineEvent.HappeningTime = DateTime.Now;

            if(handle != null)
            {
                try
                {
                    webEngineEvent.Name = ((ILILOWebEngineHandle)handle).InstanceName;
                }
                catch 
                {
                    webEngineEvent.Name = "**UNAUTHORIZED**CREATOR**";
                }
            }
            else
            {
                webEngineEvent.Name = "Unknown";
            }

            webEngineEvent.NeedsToAccept = false;

            try
            {
                webEngineEvent.EventToken = new Tokenizer(24, 6).GenerateRandomToken();
                _EVENTs.Add(webEngineEvent);
            }
            catch (Exception ex)
            {
                Exceptions.Add(ex);
                throw;
            }
        }

        public void ClearEvents(string key)
        {
            if (key == LocalServer.Instance.Options.ApiKey)
            {
                _EVENTs.Clear();
            }
        }
    }
}
