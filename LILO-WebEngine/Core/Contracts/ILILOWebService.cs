using LILO_WebEngine.Shared;

namespace LILO_WebEngine.Core.Contracts
{
    public interface ILILOWebService : ILILOWebEngineHandle
    {
        public string Name { get; }
        public bool IsRunning { get; }
        public string SourceDirectory { get; }
        public Task Stop();
        public void Dispose();
        public Task<bool> Start();
        public ILILOServerOptions Options { get; }
        public Task<InitializationResponse> Initialization(ILILOServerOptions serverOptions);
    }
}
