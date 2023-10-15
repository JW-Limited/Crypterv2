using LILO_Packager.v2.Core.Interfaces;

namespace LILO_Packager.v2.Core.Updates
{
    public class SemanticVersion : ICrypterv2Version
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }
        public string Edition { get; set; }
        public bool IsNewer { get; set; }

        public SemanticVersion(int major, int minor, int patch, string edition, bool isNewer)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
            Edition = edition;
            IsNewer = isNewer;
        }

        public override string ToString()
        {
            return $"{Major}.{Minor}.{Patch}-{Edition}";
        }
    }
}
