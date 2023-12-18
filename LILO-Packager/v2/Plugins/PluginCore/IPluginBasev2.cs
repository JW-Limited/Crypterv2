using LILO_Packager.v2.Plugins.ThirdParty.Types;

namespace LILO_Packager.v2.Plugins.PluginCore
{
    public interface IPluginBasev2 : IPluginBase, IDisposable
    {
        public Bitmap PluginIcon { get; set; }
        public string Company { get; set; }
        public HashSet<Permission> Permissions { get; set; }
        public HashSet<DependencyInfo> Dependencies { get; set; }
        public string RepoLink { get; set; }
        public ShellIntegration ShellIntegration { get; set; }


        public bool Responding();
    }

    public struct Permission
    {
        public PermissionType Type { get; set; }
        public string Description { get; set; }
        public string UseCase { get; set; }
    }

    public class ShellIntegration
    {
        public string ShellNameKey { get; set; }
        public ShellPage ShellPage { get; set; }
        public Task<bool> ShellTask { get; set; }
    }

    public enum ShellPage
    {
        Histroy,
        PasswordManager,
        Encrypten,
        Decrypten
    }

    public enum PermissionType : uint
    {
        AccessLocation = 0x1,
        AccessBroadCast = 0x2,
        AccessStorage = 0x3,
        AccessNetwork = 0x4,
        AccessNetworkInformation = 0x5,
        BroadCastMessage = 0x6,
        AccessBroadCastLog = 0x7,
        AccessStorageLog = 0x8,
        AccessMainHostLog = 0x9,
        ChangeWebEngineSettings = 0x10, 
        AccessToMainHostAPI = 0x11,
        AccessCacheContainer = 0x12,
        InsertIntoCacheContainer = 0x13,
        AccessHistoryDatabase = 0x14,
        AccessWebEngineInterface = 0x15,
        AccessWebEngineHistory = 0x16,
        LocalApi = 0x20,
    }
}
