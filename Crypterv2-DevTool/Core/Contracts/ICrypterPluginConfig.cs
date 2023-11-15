namespace Crypterv2.DevTool.Core.Contracts
{
    public interface ICrypterPluginConfig
    {
        string Changes { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        string PluginIcon { get; set; }
        string State { get; set; }
        string Version { get; set; }
    }
}