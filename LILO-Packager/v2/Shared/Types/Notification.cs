using LILO_Packager.v2.Shared.Interfaces;

namespace LILO_Packager.v2.Shared.Types
{
    public class Notification : IWinNotification
    {
        public Notification(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string Title { get; set; }
        public string Text { get; set; }
    }
}
