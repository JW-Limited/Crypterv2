namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface ILILONotifyIconManager
    {
        void OnClickOpen(object sender, EventArgs e);
        void OnClickOpenDebug(object sender, EventArgs e);
        void OnExit(object sender, EventArgs e);
        void ShowBubbleNotification(IWinNotification noti);
    }
}