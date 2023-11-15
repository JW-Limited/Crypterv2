namespace LILO_WebEngine.Core.Request
{
    public class MediaFile
    {
        public string Path { get; set; }
        public string ContentType { get; set; }
        public long Length { get; set; }

        public MediaFile(string path, string contentType, long length)
        {
            Path = path;
            ContentType = contentType;
            Length = length;
        }

        public async Task<Stream> OpenReadAsync()
        {
            return new FileStream(Path, FileMode.Open);
        }
    }

}
