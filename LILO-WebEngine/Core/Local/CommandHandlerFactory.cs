using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Handler;

namespace LILO_WebEngine.Core.Local
{
    public class CommandHandlerFactory
    {
        private readonly ILILOWebService _serviceProvider;

        public CommandHandlerFactory(ILILOWebService serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
                default:
                    if(command is "" or null)
                    {
                        throw new Exception("No Command Provided.");
                    }
                    throw new Exception($"Unknown command: {command}");
            }
        }
    }
}
