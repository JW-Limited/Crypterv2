namespace LILO_Packager.v2.Streaming.MusikPlayer.Core
{
    public interface ISongEntry
    {
        string Artist { get; set; }
        int Id { get; set; }
        string Title { get; set; }
        string Place { get; set; }
    }
}