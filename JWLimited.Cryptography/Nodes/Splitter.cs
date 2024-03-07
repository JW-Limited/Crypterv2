namespace JWLimited.Cryptography.Nodes
{
    public class SplitResult
    {
        public bool Success { get; set; }
        public List<string> GeneratedFiles { get; set; }
        public Exception Error { get; set; }
    }

    public class Splitter
    {
        private readonly NodeManager<byte[]> nodeManager;

        public Splitter(NodeManager<byte[]> nodeManager)
        {
            this.nodeManager = nodeManager ?? throw new ArgumentNullException(nameof(nodeManager));
        }

        public Task<SplitResult> SplitAndSave(string filePath, int chunkSize)
        {
            var result = new SplitResult
            {
                GeneratedFiles = new List<string>(),
                Success = true
            };

            try
            {
                if (chunkSize <= 0)
                {
                    throw new ArgumentException("Chunk size must be greater than zero.", nameof(chunkSize));
                }

                byte[] buffer = new byte[chunkSize];
                int bytesRead;

                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int index = 1;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        byte[] chunk = new byte[bytesRead];
                        Array.Copy(buffer, chunk, bytesRead);

                        nodeManager.Add(chunk);

                        string chunkFileName = $"{Path.GetFileNameWithoutExtension(filePath)}.part{index}{Path.GetExtension(filePath)}";
                        result.GeneratedFiles.Add(chunkFileName);
                        nodeManager.SaveToSeparateFiles(Path.GetTempPath(), _ => chunkFileName);

                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex;
            }

            return Task.FromResult(result);
        }
    }
}
