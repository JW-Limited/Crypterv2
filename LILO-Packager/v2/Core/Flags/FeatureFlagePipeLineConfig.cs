namespace LILO_Packager.v2.Core
{
    public class FeatureFlagePipeLineConfig
    {
        public static string PipeName { get; } = "FeatureFlagPipe";
        public static bool DebugModeEnabled { get; } = config.Default.debugMode;
    }
}
