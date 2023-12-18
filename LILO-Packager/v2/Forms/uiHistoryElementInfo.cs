using LILO_Packager.Properties;
using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Shared.Streaming.Core;
using LILO_Packager.v2.Shared.Types;
using LILO_Packager.v2.Streaming.MusikPlayer.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIAutomationClient;
using Windows.Storage;

namespace LILO_Packager.v2.Forms
{
    public partial class uiHistoryElementInfo : Form
    {
        public HistoryElement _file;

        public uiHistoryElementInfo(HistoryElement ele)
        {
            InitializeComponent();

            _file = ele;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr ExtractAssociatedIcon(IntPtr hInst,
                                                            string lpIconPath, out ushort lpiIcon);

        static Icon GetFileIcon(string filePath)
        {
            ushort iconIndex;
            IntPtr hIcon = ExtractAssociatedIcon(IntPtr.Zero, filePath, out iconIndex);
            if (hIcon != IntPtr.Zero)
            {
                Icon icon = (Icon)Icon.FromHandle(hIcon).Clone();
                DestroyIcon(hIcon);
                return icon;
            }
            return null;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        private async void uiHistoryElementInfo_Load(object sender, EventArgs e)
        {
            lblFile.Text = new FileInfo(_file.outputFileName).Name;
            lblDirectory.Text = _file.outputFileName.Replace(new FileInfo(_file.outputFileName).Name, "");
            lblDescription.Text = "Library: " + _file.mode;
            lblDes2.Text = $"Mode: " + _file.operationType;
            lbl3.Text = "Algorythemversion: " + _file.algorithmVersion;
            lblMoreInfo.Text = "InputFile: " + _file.inputFileName;

            var fileIcon = GetFileIcon(_file.outputFileName);
            pnlImage.BackgroundImage = fileIcon.ToBitmap();

            var appName = await GetDefaultApplication(_file.outputFileName);

            var cloudMatrixFile = FileIndexStorage.Instance.GetMatrixFile();

            foreach (var item in cloudMatrixFile.MatrixEntrys)
            {
                if (item.Identity.FileHash == CloudSyncroniztationBase.GetFileHash(_file.outputFileName))
                {
                    lblID.Text = item.CloudEntry.PublicFileId;
                    lblHash.Text = item.Identity.FileHash;
                    lblDateUploaded.Text = item.Identity.Timestamp.ToLocalTime().ToString();
                }
            }

            if (appName is not null)
            {
                if (appName.DefaultApp is "LILO Secured File")
                {
                    appName.DefaultApp = "Crypterv2"; pnlImage.BackgroundImage = Resources.Lock;
                }
                else if (appName.DefaultApp is "Crypterv2 Debug Session")
                {
                    appName.DefaultApp = "Crypterv2 Debuger";
                    pnlImage.BackgroundImage = Resources.debug_win;
                }
                else if (appName.DefaultApp is "LILO Custom Style")
                {
                    appName.DefaultApp = "Crypterv2 ThemeManager";
                    pnlImage.BackgroundImage = Resources.theme_manager;
                }
                else if (appName.DefaultApp is "LILO Extension")
                {
                    appName.DefaultApp = "Crypterv2 PluginInstaller";
                    pnlImage.BackgroundImage = Resources.icons8_bursts_96;
                }

                lblApp.Text = appName.DefaultApp.Replace(appName.Extension, "");

                if (_file.outputFileName.EndsWith(".llcp"))
                {
                    pnlImage.BackgroundImage = Resources.icons8_earth_planet_96;

                    foreach (var item in cloudMatrixFile.MatrixEntrys)
                    {
                        if (item.File.RealPath == _file.outputFileName.Replace(".llcp",""))
                        {
                            lblID.Text = item.CloudEntry.PublicFileId;
                            lblHash.Text = item.Identity.FileHash;
                            lblDateUploaded.Text = item.Identity.Timestamp.ToLocalTime().ToString();
                        }
                    }
                }
            }
            else
            {
                lblApp.Text = "default - " + $" ({new FileInfo(_file.outputFileName).Extension})";
            }
        }

        private async void bntOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", _file.outputFileName);
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());
        }

        public async Task<FileAppInformation> GetDefaultApplication(string filePath)
        {

            var info = new FileAppInformation()
            {
                Name = new FileInfo(filePath).Name,
            };

            try
            {
                string extension = System.IO.Path.GetExtension(filePath);

                ConsoleManager.Instance().WriteLineWithColor($"Searching for Application to open: {new FileInfo(filePath).Name} - ({extension})", ConsoleColor.White);

                if (!string.IsNullOrWhiteSpace(extension))
                {
                    info.Extension = extension;

                    using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(extension))
                    {
                        if (key != null)
                        {
                            object defaultValue = key.GetValue(null);

                            info.DefaultApp = $"{defaultValue}";

                            ConsoleManager.Instance().WriteLineWithColor($"RegEdit (KEY): {defaultValue}", ConsoleColor.White);

                            if (defaultValue != null)
                            {
                                using (RegistryKey fileTypeKey = Registry.ClassesRoot.OpenSubKey(defaultValue.ToString()))
                                {

                                    ConsoleManager.Instance().WriteLineWithColor($"RegEdit (TYPE): {fileTypeKey}", ConsoleColor.White);

                                    if (fileTypeKey != null)
                                    {
                                        using (RegistryKey shellKey = fileTypeKey.OpenSubKey("shell"))
                                        {
                                            ConsoleManager.Instance().WriteLineWithColor($"RegEdit (SHELL): {shellKey}", ConsoleColor.White);

                                            if (shellKey != null)
                                            {
                                                object shellDefaultValue = shellKey.GetValue(null);
                                                if (shellDefaultValue != null)
                                                {
                                                    ConsoleManager.Instance().WriteLineWithColor($"RegEdit (DEFAULT): {shellDefaultValue}", ConsoleColor.White);

                                                    using (RegistryKey openCommandKey = shellKey.OpenSubKey(shellDefaultValue.ToString() + "\\command"))
                                                    {
                                                        if (openCommandKey != null)
                                                        {
                                                            object applicationValue = openCommandKey.GetValue(null);

                                                            info.OpenCommand = $"{applicationValue}";

                                                            ConsoleManager.Instance().WriteLineWithColor($"RegEdit (APP): {applicationValue}", ConsoleColor.White);

                                                            if (applicationValue != null)
                                                            {
                                                                return info;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            ConsoleManager.Instance().WriteLineWithColor("Error: OpenCommandNull", ConsoleColor.DarkRed);
                                                            return info;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    ConsoleManager.Instance().WriteLineWithColor("Error: ShellValueNull", ConsoleColor.DarkRed);
                                                    return info;
                                                }
                                            }
                                            else
                                            {
                                                ConsoleManager.Instance().WriteLineWithColor("Error: ShellKeyNull", ConsoleColor.DarkRed);
                                                return info;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        ConsoleManager.Instance().WriteLineWithColor("Error: FileTypeKeyNull", ConsoleColor.DarkRed);
                                        return info;
                                    }
                                }
                            }
                            else
                            {
                                ConsoleManager.Instance().WriteLineWithColor("Error: DefaultValueNull", ConsoleColor.DarkRed);
                                return info;
                            }
                        }
                        else
                        {
                            ConsoleManager.Instance().WriteLineWithColor("Error: KeyNull", ConsoleColor.DarkRed);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblApp.Text = "Error";

                ConsoleManager.Instance().WriteLineWithColor("Error: " + ex.Message, ConsoleColor.DarkRed);
            }

            return null;
        }

        private void bntOpenDirectory(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri($"http://localhost:{MainHost.Instance().Port}/" + _file.outputFileName.Replace(new FileInfo(_file.outputFileName).Name, ""))));
        }

        private async void bntPreview_Click(object sender, EventArgs e)
        {
            bntPreview_C(sender, e);
        }

        private async void bntShareFIle(object sender, EventArgs e)
        {
            var shareManager = new ShareManager();
            await shareManager.OpenShareDialogAsync(_file.outputFileName);
        }


        private async void bntPreview_C(object sender, EventArgs e)
        {
            if (_file.outputFileName.EndsWith(".pdf"))
            {
                MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri(_file.outputFileName)));
            }
            else if (_file.outputFileName.EndsWith(".mp3") ||
                     _file.outputFileName.EndsWith(".wav") ||
                     _file.outputFileName.EndsWith(".m4a") ||
                     _file.outputFileName.EndsWith(".aac"))
            {
                if (config.Default.openMediaIn != "buildIn" || !FeatureManager.IsFeatureEnabled(FeatureFlags.SecuredContainerStreaming))
                {
                    MessageBox.Show("You need to enable this feature first because its still in development.", "Activation required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.FormClosing += (sender, e) =>
                {
                    e.Cancel = true;
                    this.Hide();
                };

                if (FeatureManager.IsFeatureEnabled(FeatureFlags.MediaEngineManager))
                {
                    var para = await MusicPlayerParameters.Get(_file.outputFileName);
                    var player = uiPlayer.Instance(para, false);
                    Program.InstanceCacheContainer.Resolve<ILILOMainHost>().OpenInApp(player);
                }
                else
                {
                    var para = await MusicPlayerParameters.Get(_file.outputFileName);
                    var mediaInstance = new Streaming.MusikPlayer.Forms.uiPlayerDynamic(para, this);
                    MainHost.Instance().OpenInApp(mediaInstance);
                }
            }
            else
            {
                foreach (var plugin in MainHost.Instance()._pluginManager.Pluginsv1)
                {
                    if (PluginID.IDtoString(plugin.ID) == PluginID.IDtoString(PluginID.GetID("tpl", "lbl", "lvl02")))
                    {
                        ConsoleManager.Instance().WriteLineWithColor("Showed Previewer", ConsoleColor.Yellow);

                        var list = new List<object>
                        {
                            _file.outputFileName
                        };

                        plugin.Initialize(new PluginParameters()
                        {
                            needNewInstance = true,
                        });

                        var responseEx = plugin.Execute(new PluginParameters()
                        {
                            Context = list,
                            themeManager = MainHost.Instance()._thManager,
                        });

                        if (responseEx.HasError)
                        {
                            ConsoleManager.Instance().WriteLineWithColor(responseEx.Message + responseEx.MESSAGE_UINT, ConsoleColor.DarkRed);
                        }

                        MainHost.Instance().OpenInApp(plugin.PluginInterface);
                    }
                }
            }
        }

        private void bntPreviewInfo_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bntCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblID.Text);
        }
    }
}
