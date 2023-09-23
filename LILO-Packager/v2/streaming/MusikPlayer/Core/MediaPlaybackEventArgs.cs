namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{
    public class MediaPlaybackEventArgs : EventArgs
    {
        public MediaPlaybackStatus Status { get; set; }
        public string ErrorMessage { get; set; }
        public string CurrentPositionInSeconds { get; set; }
        public string DurationInSeconds { get; set; }
        public int CurrentPositionInSeconds_int { get; set; }
        public int DurationInSeconds_int { get; set; }
    }
}
