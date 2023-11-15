using LILO_WebEngine.Shared;
using Windows.Devices.Bluetooth.Advertisement;

namespace LILO_WebEngine.Core.Local.Types;

public class WEB_ENGINE_STATE
{
    public required string PublicName { get; set; }
    public required string PublicApiKey { get; set; }
    public required string PublicSecret { get; set; }
    public required string PublicLogDirectory { get; set; }
    public int PublicLoopbackPort { get; set; }

    public Port? AvaillabelPorts { get; set; } = new Port()
    {
        Default = 8080,
        FallBack = 9002
    };

    public string? RequestHandler { get; set; }   

    public required string PublicServedDirectory { get; set; }

    public required string HealthCheckStatus { get; set; }
    public required string HealthCheckResponse { get; set; }

    public required string LibraryVersion { get; set; }

    public List<WEB_ENGINE_EVENT> PublicEvents { get; set; }
}

