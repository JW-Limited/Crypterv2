using LILO_Packager.v2.Shared.Api.Core;

namespace LILO_Packager.v2.Shared.Api.Types
{
    public class BroadcastMessage : IBroadcastMessage
    {
        public BroadcastMessageType Type { get; private set; }
        public BroadcastEndPoint EndPoint { get; private set; }
        public string? Payload { get; private set; }
        public BroadCastMessageParameters? BroadcastMessageArgs { get; private set; }

        public BroadcastMessage(BroadcastMessageType type,
                                BroadcastEndPoint endPoint,
                                string payload)
        {
            Type = type;
            EndPoint = endPoint;
            Payload = payload;
        }

        public BroadcastMessage(BroadcastMessageType type,
                                BroadcastEndPoint endPoint,
                                BroadCastMessageParameters castMessageParameters)
        {
            Type = type;
            EndPoint = endPoint;
            BroadcastMessageArgs = castMessageParameters;
        }
    }
}
