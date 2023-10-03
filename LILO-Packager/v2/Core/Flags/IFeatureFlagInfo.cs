namespace LILO_Packager.v2.Core
{
    public interface IFeatureFlagInfo
    {
        FeatureFlags Feature { get; }
        bool IsEnabled { get; }
    }
}