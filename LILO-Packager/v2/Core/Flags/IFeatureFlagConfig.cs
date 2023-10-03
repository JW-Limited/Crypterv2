namespace LILO_Packager.v2.Core
{
    public interface IFeatureFlagConfig
    {
        bool HistoryElementQuering { get; set; }
        bool NewEncryptionCore { get; set; }
        bool PluginManager { get; set; }
        bool PluginSupport { get; set; }
        bool SecuredContainerStreaming { get; set; }
        bool ThirdPartyPluginSupport { get; set; }
        bool WebView2GraphicalContent { get; set; }
    }
}