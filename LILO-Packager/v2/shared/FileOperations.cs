using System.Runtime.InteropServices;

namespace LILO_Packager.v2.Shared;

public partial class FileOperations
{
    public enum CrypterFileType
    {
        EncryptedFile,
        CustomStyleSheet,
        CrypterExtension,
        DebugSession,
        CloudEntry,
        CloudClearifingEntry,
        CloudEntryDeclaration
    }

    private static  Dictionary<CrypterFileType, string> _fileExtensions = new Dictionary<CrypterFileType, string>() 
    {
        { CrypterFileType.EncryptedFile, ".lsf"},
        { CrypterFileType.CustomStyleSheet, ".lcs"},
        { CrypterFileType.CrypterExtension, ".cryptex"},
        { CrypterFileType.DebugSession, ".dbgsl"},
        { CrypterFileType.CloudEntry, ".cdex" },
        { CrypterFileType.CloudClearifingEntry, ".cdcex" },
        { CrypterFileType.CloudEntryDeclaration,".cdex.info" }
    };

    public static string GetFileExtension(CrypterFileType type)
    {
        return _fileExtensions.First(k => k.Key == type).Value;
    }

    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr ExtractAssociatedIcon(IntPtr hInst,
                                                            string lpIconPath, out ushort lpiIcon);

    public static Icon GetFileIcon(string filePath)
    {
        ushort iconIndex;
        IntPtr hIcon = ExtractAssociatedIcon(IntPtr.Zero, filePath, out iconIndex);
        if (hIcon != IntPtr.Zero)
        {
            Icon icon = (Icon)Icon.FromHandle(hIcon).Clone();
            DestroyIcon(hIcon);
            return icon;
        }
        return null;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern bool DestroyIcon(IntPtr handle);

    public static void CreateDirectoryRecursively(string path)
    {
        string[] pathComponents = path.Split(Path.DirectorySeparatorChar);

        string currentDirectory = "";
        foreach (string pathComponent in pathComponents)
        {
            currentDirectory = Path.Combine(currentDirectory, pathComponent);

            if (!Directory.Exists(currentDirectory))
            {
                Directory.CreateDirectory(currentDirectory);
            }
        }
    }

    public static string GetSizeString(long size)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        int order = 0;
        while (size >= 1024 && order < sizes.Length - 1)
        {
            order++;
            size /= 1024;
        }
        return $"{size} {sizes[order]}";
    }

    public string GetFileExtensionFromType(CrypterFileType value)
    {
        _fileExtensions.TryGetValue(value, out string? returnValue);
        return returnValue ?? "";
    }

    public string GetFileFromDialog()
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = false;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileName;
        }

        else { return null; }
    }

    public string[] GetFilesFromDialog()
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileNames;
        }

        else { return null; }
    }

    public string[] GetFilesFromDialogFilter(FilterType type)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.Filter = FileDialogFilter.GetFilter(type);
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileNames;
        }

        else { return null; }
    }
}
