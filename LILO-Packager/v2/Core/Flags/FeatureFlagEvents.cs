namespace LILO_Packager.v2.Core
{
    public static class FeatureFlagEvents
    {
        public static event EventHandler<FeatureFlagUpdateEventArgs> FeatureFlagUpdateRequested;

        public static void OnFeatureFlagUpdateRequested(FeatureFlags feature, bool isEnabled)
        {
            FeatureFlagUpdateRequested?.Invoke(null, new FeatureFlagUpdateEventArgs(feature, isEnabled));
        }
    }
}
