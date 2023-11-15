namespace LILO_WebEngine.Core.Local.Types;

public struct WEB_ENGINE_EVENT
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool NeedsToAccept { get; set; }
    public DateTime HappeningTime { get; set; }
    public string EventToken { get; set; }
}

