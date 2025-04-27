using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.WebSockets;
using System.Net;

namespace LILO_WebEngine.Core.Local
{
    public class CommandHandlerFactory
    {
        private readonly ILILOWebService _serviceProvider;
        private readonly WebSocketCommandHandler _webSocketCommandHandler;

        public CommandHandlerFactory(ILILOWebService serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _webSocketCommandHandler = new WebSocketCommandHandler();
        }

        public ICommandHandler CreateCommandHandler(string command)
        {
            switch (command)
            {
                case "close":
                    return new CloseCommandHandler(_serviceProvider);
                case "state":
                    return new StateCommandHandler();
                case "state/logs":
                    return new LogCommandHandler();
                case "state/events" or "state/events/":
                    return new EngineEventsCommandHandler();
                case "search":
                    return new SearchCommandHandler();
                case "get_commands":
                    return new GetCommandListCommandHandler();
                case "events":
                    return new EngineEventsCommandHandler();
                case "ws/reload":
                    return new DelegateCommandHandler(_webSocketCommandHandler.HandleTriggerReload);
                case "ws/connections":
                    return new DelegateCommandHandler(_webSocketCommandHandler.HandleGetConnections);
                default:
                    if(command is "" or null)
                    {
                        throw new Exception("No Command Provided.");
                    }
                    throw new Exception($"Unknown command: {command}");
            }
        }
    }
    
    // Helper class to allow using method delegates as command handlers
    public class DelegateCommandHandler : ICommandHandler
    {
        private readonly Func<HttpListenerRequest, HttpListenerResponse, Task> _handlerFunc;
        
        public DelegateCommandHandler(Func<HttpListenerRequest, HttpListenerResponse, Task> handlerFunc)
        {
            _handlerFunc = handlerFunc;
        }
        
        public async Task Handle(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context = null)
        {
            await _handlerFunc(request, response);
        }
    }
}
