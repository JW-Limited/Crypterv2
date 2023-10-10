namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface IEncryptedFile
    {
        byte[] Data { get; set; }
        string Encryption { get; set; }
        string FileName { get; set; }
        long Length { get; set; }
        string Path { get; set; }
        string Size { get; set; }
    }
}