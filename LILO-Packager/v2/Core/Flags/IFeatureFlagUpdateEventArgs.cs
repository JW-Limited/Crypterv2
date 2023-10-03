namespace LILO_Packager.v2.Core
{
    public interface IFeatureFlagUpdateEventArgs
    {
        FeatureFlags Flag { get; }
        bool NewValue { get; }
    }
}