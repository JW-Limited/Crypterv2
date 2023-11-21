namespace LILO_Packager.v2.Plugins.PluginCore
{
    public class IndexFileInvalidException : Exception
    {
        public IndexFileInvalidException(string filename) 
            :base($"The Indexfile \"{new FileInfo(filename).Name}\" with  working directory \"{new FileInfo(filename).Directory}\" is invalid.",
                 new Exception("Some values of the file were unexpectedly filled with wrong data."))
        {
            base.Source = "PluginManagerv2.Indexer";
            base.HelpLink = "https://www.beta.lilo.com/help/topic/invalid_index";
        }
    }
}




