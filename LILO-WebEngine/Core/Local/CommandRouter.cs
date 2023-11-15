using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Pages;
using System.Net;

namespace LILO_WebEngine.Core.Local
{
    public class CommandRouter
    {
        private readonly CommandHandlerFactory _commandHandlerFactory;
        private readonly ErrorHandler _errorHandler;

        public CommandRouter(CommandHandlerFactory commandHandlerFactory)
        {
            _commandHandlerFactory = commandHandlerFactory;
            _errorHandler = new ErrorHandler(new ErrorHtmlDynamic()); 
        }

        public async Task HandleRequest(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context)
        {
            //var command = Regex.Match(request.RawUrl, @"/api/(?<command>[^\/]+)").Groups["command"].Value;
            //
            //              Doenst worked as expexted

            var commandv2 = request.Url.LocalPath.TrimStart('/').Replace("api/","");


            var commandHandler = _commandHandlerFactory.CreateCommandHandler(commandv2);

            ArgumentNullException.ThrowIfNull(commandHandler, nameof(commandHandler));

            try
            {
                await commandHandler.Handle(request, response, context);
                response.Close();
            }
            catch (Exception ex)
            {
                await _errorHandler.Handle(context, HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
