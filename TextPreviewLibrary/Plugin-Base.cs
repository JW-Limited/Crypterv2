using LILO_Packager.v2.Core.Visuals;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using TextPreviewLibrary.Core.Formats;
using LILO_Packager.v2.Shared.Api.Core;
using TextPreviewLibrary.Core;
using System.Drawing;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using JWLimited.Licensing.Schemes;
using LILO_Packager.v2;
using TextPreviewLibrary.Properties;

namespace TextPreviewLibrary
{
    public class PluginBase : IPluginBasev2
    {
        public string Name { get; set; } = "TextPreviewLibrary";
        public BroadcastChannel Channel { get; set; }
        public PluginID ID { get; set; } = PluginID.GetID("tpl", "lbl", "lvl02");
        public string Description { get; set; } = "A Library for previewing plain based Files";
        public string Version { get; set; } = "v0.12.3-beta";
        public Bitmap PluginIcon { get; set; } = Resources.icons8_foxit_reader_240;
        public static SemanticVersion _sVersion = new SemanticVersion(0, 1, 2, "alpha", false);
        public Form PluginInterface { get; set; } = Core.PluginInterface.Instance("v0.1", PluginID.GetID("tpl", "lbl", "lvl02"), "Text-Preview",true);
        public string Company { get; set; } = "JW Limited © 2023";

        public static ThemeManager _thManager;
        public static BroadcastChannel channelToMainHost { get; set; } = null;
        public ObservableCollection<object> DynamicValues { get; set; }
        public MainHost MainHostInstance { get; set; }

        private bool disposedValue;


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

        public PluginResponse Execute(PluginParameters args)
        {

            var para = new PluginResponse();

            try
            {

                var file = (string)args.Context[0];

                if (file.EndsWith(".ctv"))
                {
                    var content = CrypterTextFile.LoadInstanceFromFile(file);
                    Core.PluginInterface.Instance(null, null, null, args.needNewInstance).SetContent(content);
                }
                else
                {
                    Core.PluginInterface.Instance(null, null, null, args.needNewInstance).SetContent(new CrypterTextFile()
                    {
                        RtfContent = File.ReadAllText(file),
                        IsLocked = false,
                        FileName = Path.GetFileName(file),
                        Author = "n/a"
                    });
                }
                
                Channel = args.Channel;
                channelToMainHost = args.Channel;
                Channel.Subscribe(new PluginBroadCastObserver(),"TPL - Plugin");

                para.HasError = false;
                para.Message = "Executed Succesfully";
                para.MessageID = "0x0";
            }
            catch (Exception ex)
            {
                para.HasError = true;
                para.MESSAGE_UINT = 0x19129;
                para.Message = ex.Message + ex.StackTrace + ex.InnerException;
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
            PluginInterface.Dispose();
            return para;
        }

        public bool Responding()
        {
            return !PluginInterface.IsDisposed && PluginInterface.IsHandleCreated;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    PluginInterface.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
