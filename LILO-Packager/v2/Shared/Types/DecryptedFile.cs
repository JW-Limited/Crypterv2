using LILO_Packager.v2.Shared.Interfaces;

namespace LILO_Packager.v2.Shared.Types
{
    public class DecryptedFile : IDecryptedFile
    {
        public string FileName { get; set; } = null;
        public byte[] Data { get; set; } = null;
        public long Length { get; set; } = 0;
        public string Size { get; set; } = null;
        public string Encryption { get; set; } = null;
        public string Path { get; set; } = null;

        public DecryptedFile(string file)
        {
            FileInfo fileInfo = new FileInfo(file);

            FileName = fileInfo.Name;
            Length = fileInfo.Length;
            Size = GetSizeString(fileInfo.Length);
            Encryption = "null";
            Path = fileInfo.FullName;
        }

        public string GetSizeString(long size)
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
    }
}
