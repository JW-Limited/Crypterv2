using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptionLibary
{
    public class PluginBase : IPluginBasev2
    {
        public string Name { get; set; } = "Encryption Library";
        public PluginID ID { get; set; } = PluginID.GetID("enc","lbl","lvl01");
        public string Description { get; set; } = "A Library for more Encryption Models";
        public string Version { get; set; } = "v0.20.1-beta";
        public Form PluginInterface { get; set; } = Core.PluginInterface.Instance("v0.20.1-beta", PluginID.GetID("enc", "lbl", "lvl01"), "EncryptionLibary Installer");

        public ObservableCollection<object> DynamicValues { get; set; }
        public string Company { get; set; } = "JW Limited © 2023";
        public HashSet<Permission> Permissions { get; set; } = new HashSet<Permission>()
        {
            new()
            {
                Type = PermissionType.AccessStorage,
                Description = "To store the downloaded Librarys.",
                UseCase = "Installing"
            },
            new()
            {
                Type = PermissionType.AccessCacheContainer,
                Description = "To store the plugin Instance.",
                UseCase = "Runtime"
            },
            new()
            {
                Type = PermissionType.AccessNetwork,
                Description = "To download Encryption Models.",
                UseCase = "Downloading"
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
            }
        };

        public HashSet<DependencyInfo> Dependencies { get; set; }
        public string RepoLink { get; set; } = "https://github.com/JW-Limited/Crypterv2/raw/main/PackagedPlugins/CrypterLibrary.cryptex";
        public ShellIntegration ShellIntegration { get; set; } = new ShellIntegration()
        {
            ShellNameKey = "Change Model",
            ShellPage = ShellPage.Encrypten,
        };
        public Bitmap PluginIcon { get; set; } = Properties.Resources.lockView;

        public PluginResponse Execute(PluginParameters args)
        {
            var para = new PluginResponse();

            try
            {
                para.HasError = false;
                para.Message = "Executed Succesfully";
                para.MessageID = "0x01";
            }
            catch (Exception ex)
            {
                para.HasError = true;
                para.Message = ex.Message;
                para.MessageID = "0x10";
            }
            

            return para;
        }

        public PluginResponse Initialize(PluginParameters args)
        {
            var para = new PluginResponse();

            try
            {
                para.HasError = false;
                para.Message = "Initilized Succesfully";
                para.MessageID = "0x0";

                return para;
            }
            catch (Exception ex)
            {
                para.HasError = true;
                para.Message = ex.Message;
                para.MessageID = "0x10";

                return para;
            }
            
        }

        public PluginResponse Close()
        {
            var para = new PluginResponse();
            return para;
        }

        public bool Responding()
        {
            return true;
        }

        public void Dispose()
        {
            PluginInterface.Dispose();
        }
    }
}