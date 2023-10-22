using LILO_Packager.v2.Plugins.PluginCore;
using Microsoft.Extensions.FileProviders;

namespace LILO_Packager.v2.Shared.Types
{
    public interface ILILOSecuredFile : IFileInfo
    {
        public string GetSizeInReadableForm();
        public int ID { get; }
        public PluginID PreviewPlugin_ID { get; }
        Task CopyToAsync(string destination);
        Task MoveToAsync(string destination);
        Task DeleteAsync();
    }
}
