using LILO_Packager.v2.Core.Updates;
using System.Drawing;
using TextPreviewLibrary.Core.Formats;

namespace TextPreviewLibrary.Core.Contracts
{
    public interface ILILOCrypterTextFile
    {
        string Author { get; set; }
        DateTime CreatedAt { get; set; }
        string FileName { get; set; }
        bool IsLocked { get; set; }
        DateTime LastModified { get; set; }
        string RtfContent { get; set; }
        Color TextColor { get; set; }
        Font TextFont { get; set; }
        SemanticVersion version { get; set; }
        int WordCount { get; }

        bool IsDifferentFrom(CrypterTextFile otherFile);
    }
}