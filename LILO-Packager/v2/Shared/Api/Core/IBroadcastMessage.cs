using LILO_Packager.v2.Shared.Api.Types;

namespace LILO_Packager.v2.Shared.Api.Core
{
    public interface IBroadcastMessage
    {
        BroadCastMessageParameters? BroadcastMessageArgs { get; }
        BroadcastEndPoint EndPoint { get; }
        string? Payload { get; }
        BroadcastMessageType Type { get; }
    }
}