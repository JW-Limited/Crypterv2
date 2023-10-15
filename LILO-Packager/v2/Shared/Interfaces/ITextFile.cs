namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface ITextFile
    {
        bool Exists { get; }
        bool IsDirectory { get; }
        DateTimeOffset LastModified { get; }
        long Length { get; }
        string Name { get; }
        string? PhysicalPath { get; }

        Stream CreateReadStream();
        string ReadAllText();
        void WriteAllText(string text);
    }
}