using JWLimited.Licensing.Schemes;
using LILO_Packager.v2;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using LILO_Packager.v2.Shared.Api.Core;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeezerPlugin
{
    public class PluginBase : IPluginBasev2
    {
        public string Name { get; set; } = "Deezer Plugin";
        public BroadcastChannel Channel { get; set; }
        public PluginID ID { get; set; } = PluginID.GetID("dzp", "plg", "lvl03");
        public string Description { get; set; } = "A plugin to use the DeezerApi";
        public string Version { get; set; } = "v0.1.2-beta";
        public Bitmap PluginIcon { get; set; } = Resources.index.pluginIcon;
        public static SemanticVersion _sVersion = new SemanticVersion(0, 1, 2, "beta", false);
        public Form PluginInterface { get; set; } = Core.PluginInterface.Instance();
        public string Company { get; set; } = "JW Limited © 2024";

        public HashSet<Permission> Permissions { get; set; } = new HashSet<Permission>()
        {
            new()
            {
                Type = PermissionType.AccessStorage,
                Description = "To access files for preview.",
                UseCase = "Runtime"
            },
            new()
            {
                Type = PermissionType.AccessCacheContainer,
                Description = "To store the plugin Instance.",
                UseCase = "Runtime"
            },
            new()
            {
                Type = PermissionType.BroadCastMessage,
                Description = "Submit State.",
                UseCase = "Runtime"
            },
            new()
            {
                Type = PermissionType.AccessBroadCast,
                Description = "Retrieve Messages.",
                UseCase = "Runtime"
            },
            new()
            {
                Type = PermissionType.AccessExternalStorage,
                Description = "To access files for preview.",
                UseCase = "Runtime"
            },
            new()
            {
                Type = PermissionType.AccessHistoryDatabase,
                Description = "Get Exact File-State Information.",
                UseCase = "BuildEncryptenInterface"
            }
        };

        public HashSet<DependencyInfo> Dependencies { get; set; }
        public string RepoLink { get; set; } = "https://github.com/JW-Limited/Crypterv2/raw/main/PackagedPlugins/TextPreviewLibrary.cryptex";
        public string DocumentationLink { get; set; } = "https://github.com/JW-Limited/Crypterv2/blob/main/README.md";
        public ShellIntegration ShellIntegration { get; set; } = new ShellIntegration()
        {
            ShellNameKey = "View Content",
            ShellPage = ShellPage.Histroy,
        };
        public IJWLimitedLicense License { get; set; } = new ProductLicense()
        {
            OwnedUser = new JWLimited.Licensing.Schemes.Structs.User(),
            License = new PluginLicense(),
        };

        public ObservableCollection<object> DynamicValues { get; set; }
        public MainHost MainHostInstance { get; set; }

        public PluginResponse Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }

        public PluginResponse Execute(PluginParameters args)
        {
            return null;
        }

        public PluginResponse Initialize(PluginParameters args)
        {
            return null;
        }

        public bool Responding()
        {
            return true;
        }
    }
}
