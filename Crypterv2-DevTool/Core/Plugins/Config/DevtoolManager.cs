using LILO_Packager.v2.Plugins.ThirdParty.Types;

namespace Crypterv2.DevTool.Core.Plugins.Config
{
    public class DevtoolManager
    {
        public string Name { get; set; }
        public VersionInfo Version { get; set; }
        public string SchemeVersion { get; set; }

        public static DevtoolManager Default
        {
            get
            {
                return new DevtoolManager()
                {
                    Name = "Crypterv2.DevTool.Core",
                    Version = new VersionInfo()
                    {
                        Number = "2.0.11",
                        State = "dev_build",
                        ReleaseDate = "unofficial_devbuild",
                    }
                };
            }
        }
    }
}
