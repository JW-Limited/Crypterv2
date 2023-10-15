using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Shared;
using System.Text.RegularExpressions;

namespace LILO_Packager.v2.Core.Updates
{
    public class VersionComparer
    {
        private static void LogComparisonResult(int value, string category)
        {
            var isNewer = value < 0;
            ConsoleManager.Instance().WriteLineWithColor($"{category} is greater: {Math.Abs(value)} Newer: {isNewer}");
        }


        public static ICrypterv2Version ParseSemanticVersion(string version)
        {
            var semverRegex = new Regex(@"^v(\d+)\.(\d+)(?:\.(\d+))?(?:-(\w+))?(?:\+(\w+))?$");
            var match = semverRegex.Match(version);

            if (!match.Success)
            {
                throw new ArgumentException("Invalid version format.");
            }

            var major = int.Parse(match.Groups[1].Value);
            var minor = int.Parse(match.Groups[2].Value);
            var patch = match.Groups[3].Success ? int.Parse(match.Groups[3].Value) : 0;
            var edition = match.Groups[4].Value;
            var isNewer = false; 

            return new SemanticVersion(major, minor, patch, edition, isNewer);
        }

        public static ICrypterv2Version CompareSemanticVersions(string appVersion, string semanticVersion)
        {
            var appSemanticVersion = ParseSemanticVersion(appVersion);
            var semverSemanticVersion = ParseSemanticVersion(semanticVersion);

            var isNewer = appSemanticVersion.Major < semverSemanticVersion.Major ||
                          (appSemanticVersion.Major == semverSemanticVersion.Major &&
                           (appSemanticVersion.Minor < semverSemanticVersion.Minor ||
                            (appSemanticVersion.Minor == semverSemanticVersion.Minor &&
                             appSemanticVersion.Patch < semverSemanticVersion.Patch)));

            ConsoleManager.Instance().WriteLineWithColor($"Version Comparison - App: {appSemanticVersion} vs. Server: {semverSemanticVersion}");
            ConsoleManager.Instance().WriteLineWithColor($"Is Newer: {isNewer}");

            return new SemanticVersion(semverSemanticVersion.Major, semverSemanticVersion.Minor, semverSemanticVersion.Patch, semverSemanticVersion.Edition, isNewer);
        }
    }
}
