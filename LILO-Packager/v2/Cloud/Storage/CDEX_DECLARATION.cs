using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Cloud.Storage
{
    public class CDEX_DECLARATION
    {
        public FileFormatClearifier FileFormatClearifier { get; set; } = new FileFormatClearifier()
        {
            ExtensionPrefix = ".cdex",
            FriendlyName = "Cloud Shareble Object Package",
            Description = "An package filled with Shareble Objects.",
            SchemeUri = "https://beta.lilo.com/schemes/cdexinfo/1",
            FormatVersion = "1.0"
        };
    }
}
