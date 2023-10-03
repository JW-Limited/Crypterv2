namespace LILO_Packager.v2.Core
{
    public class FeatureFlagUpdateEventArgs : EventArgs, IFeatureFlagUpdateEventArgs
    {
        public FeatureFlags Flag { get; }
        public bool NewValue { get; }

        public FeatureFlagUpdateEventArgs(FeatureFlags flag, bool newValue)
        {
            Flag = flag;
            NewValue = newValue;
        }
    }
}
