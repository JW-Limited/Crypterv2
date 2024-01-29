using LILO_Packager.v2.Core.LILO.Types;

namespace LILO_Packager.v2.Cloud.Storage
{
    public class CdexArgs
    {
        public string Name { get; set; } = "";
        public string Directory { get; set; } = "";
        public string EncryptenKey { get; set; } = "";
        public List<MatrixEntry> MatrixEntries { get; set; } = null;

        // Not Essential
        public List<User> AllowedUsers { get; set; } = null;
    }
}
