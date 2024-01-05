using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Cloud.Storage
{
    public class CDEX_FILE_DECLARATION
    {
        public string Hash256;
        public bool PasswordSecured = false;
        public string PasswordEnc = null;
        public bool Encrypted = false;

        public FileFormatClearifier FileFormatClearifier { get; set; } = new FileFormatClearifier()
        {
            ExtensionPrefix = ".cdex.info",
            FriendlyName = "Cloud Shareble Object Information Provider",
            Description = "An file with information about the CDex package.",
            SchemeUri = "https://beta.lilo.com/schemes/cdexinfo/1",
            FormatVersion = "1.0"
        };

        public List<MatrixEntry> MatrixEntries { get; set; } = new List<MatrixEntry>();
        public List<string> ArchieveEntries { get; set; } = new List<string>();
    }
}
