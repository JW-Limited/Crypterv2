using LILO_WebEngine.Shared;

namespace LILO_WebEngine.Core.Contracts
{
    /// <summary>
    /// Defines the core contract for a LILO web service implementation
    /// </summary>
    public interface ILILOWebService : ILILOWebEngineHandle
    {
        /// <summary>
        /// Gets the name of the web service
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a value indicating whether the service is currently running
        /// </summary>
        public bool IsRunning { get; }

        /// <summary>
        /// Gets the source directory path for the web service
        /// </summary>
        public string SourceDirectory { get; }

        /// <summary>
        /// Stops the web service asynchronously
        /// </summary>
        /// <returns>A task representing the asynchronous stop operation</returns>
        public Task Stop();

        /// <summary>
        /// Releases all resources used by the web service
        /// </summary>
        public void Dispose();

        /// <summary>
        /// Starts the web service asynchronously
        /// </summary>
        /// <returns>A task representing the asynchronous start operation. Returns true if successful, false otherwise</returns>
        public Task<bool> Start();

        /// <summary>
        /// Gets the server configuration options
        /// </summary>
        public ILILOServerOptions Options { get; }

        /// <summary>
        /// Initializes the web service with the specified server options
        /// </summary>
        /// <param name="serverOptions">The configuration options for the server</param>
        /// <returns>A task containing the initialization response with status and configuration details</returns>
        public Task<InitializationResponse> Initialization(ILILOServerOptions serverOptions);
    }
}
