using LILO_Packager.v2.Plugins.ThirdParty.Types;

namespace LILO_Packager.v2.Plugins.ThirdParty.Interfaces
{
    public interface IPluginInformation
    {
        bool Active { get; set; }
        AuthorInfo Author { get; set; }
        List<CapabilityInfo> Capabilities { get; set; }
        CompatibilityInfo Compatibility { get; set; }
        List<DependencyInfo> Dependencies { get; set; }
        string Description { get; set; }
        LicenseInfo License { get; set; }
        string Name { get; set; }
        string PluginDll { get; set; }
        VersionInfo Version { get; set; }
        string Website { get; set; }

        void SerializeToXml(string filePath);
    }
}