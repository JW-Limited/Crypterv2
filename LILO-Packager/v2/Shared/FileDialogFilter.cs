namespace LILO_Packager.v2.Shared;

public partial class FileOperations
{
    public class FileDialogFilter
    {
        public enum FilterType
        {
            EncryptedFiles,
            EncryptedFilesLegacy,
            Default
        }

        private static Dictionary<FilterType, string> _Filter = new Dictionary<FilterType, string>()
        {
            { FilterType.EncryptedFiles,"Encrypted Files|*.lsf|Alle Datein|*" },
            { FilterType.EncryptedFilesLegacy,"LILO Legacy Files|*.lilo|Encrypted Files|*.lsf|Alle Datein|*" }
        };

        public static string GetFilter(FilterType type)
        {
            _Filter.TryGetValue(type, out string filter);
            return filter ?? "null";
        }
    }
}
