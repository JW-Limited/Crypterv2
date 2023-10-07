using LILO_Packager.v2.Shared.Api.Core;
using LILO_Packager.v2.Shared.Api.Types;

namespace LILO_Packager.v2.Core.Dialogs.Secured
{
    public class SecuredDialogPreferences
    {
        public SecuredDialogPreferences(string title, string task,string description) 
        {
            FormTitle = title;
            Task = task;
            FormDescription = description;
        }

        public SecuredDialogPreferences(string title, string task, string description, BroadcastChannel channel, BroadcastEndPoint listeningEndpoint) : 
            this(title, task, description)
        {
            if(channel is not null)
            {
                Channel = channel;
                ListeningEndpoint = listeningEndpoint;
                Channel.Subscribe(new SecuredDialogBroadCastObserver(listeningEndpoint),"SecuredMemoryHost");
                Channel.Broadcast(new BroadcastMessage(BroadcastMessageType.Info, BroadcastEndPoint.ForAll, "SecuredDialogHostInitialized - Endpoint: " + listeningEndpoint.ToString()));
            }

        }

        // Observing Tasks

        public BroadcastChannel Channel { get; set; }
        public BroadcastEndPoint ListeningEndpoint { get; set; }

        public string Task { get; set; } = string.Empty;
        public string FormTitle { get; set; } = string.Empty;
        public string FormDescription { get; set; } = string.Empty;
        public Action<SecuredDialogCallBack> Callback { get; set; }
    }
}
