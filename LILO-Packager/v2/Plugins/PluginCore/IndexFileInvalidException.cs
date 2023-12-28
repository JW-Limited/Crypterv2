namespace LILO_Packager.v2.Plugins.PluginCore
{
    public class IndexFileInvalidException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexFileInvalidException"/> class.
        /// </summary>
        /// <param name="filename">The name of the invalid index file.</param>
        public IndexFileInvalidException(string filename)
            : base($"The index file \"{GetFileName(filename)}\" in the working directory \"{GetDirectoryName(filename)}\" is invalid.",
                  new Exception("Some values in the file contain unexpected data."))
        {
            base.Source = "PluginManagerV2.Indexer";
            base.HelpLink = "https://www.beta.lilo.com/help/topic/invalid_index";
        }

        /// <summary>
        /// Gets the file name from the specified path.
        /// </summary>
        /// <param name="path">The full path to the file.</param>
        /// <returns>The name of the file.</returns>
        private static string GetFileName(string path) => new FileInfo(path).Name;

        /// <summary>
        /// Gets the directory name from the specified path.
        /// </summary>
        /// <param name="path">The full path to the directory.</param>
        /// <returns>The name of the directory.</returns>
        private static string GetDirectoryName(string path) => new FileInfo(path).Directory?.FullName ?? "Unknown Directory";
    }
}




