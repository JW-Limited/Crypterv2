using LILO_Packager.Properties;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.plugins.Model;
using LILO_Packager.v2.plugins.PluginCore;
using LILO_Packager.v2.shared;
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
            lblDes2.Text = "Mode: " + _file.operationType;
            lbl3.Text = "Algorythemversion: " + _file.algorithmVersion;

            var fileIcon = GetFileIcon(_file.outputFileName);
            pnlImage.BackgroundImage = fileIcon.ToBitmap();

            var appName = await GetDefaultApplication(_file.outputFileName);
            if (appName is not null)
            {
                if (appName.DefaultApp is "LILO secured File") { appName.DefaultApp = "Crypterv2"; pnlImage.BackgroundImage = Resources.Lock; }

                lblApp.Text = appName.DefaultApp.Replace(appName.Extension, "");
            }
            else
            {
                lblApp.Text = "default - " + $" ({new FileInfo(_file.outputFileName).Extension})";
            }
        }

        private async void bntOpen_Click(object sender, EventArgs e)
        {
            if ((_file.outputFileName.EndsWith(".mp3") || _file.outputFileName.EndsWith(".wav")) && config.Default.openMediaIn == "buildIn")
            {
                var para = await streaming.MusikPlayer.Core.MusicPlayerParameters.Get(_file.outputFileName);
                var mediaInstance = streaming.MusikPlayer.Forms.uiPlayer.Instance(para, true);
                MainHost.Instance().OpenInApp(mediaInstance);
            }
            else
            {
                
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());
        }

        public string GetDefaultApplicationName(string extension)
        {
            try
            {
                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(extension))
                {
                    if (key != null)
                    {
                        object friendlyAppName = key.GetValue("FriendlyAppName");
                        if (friendlyAppName != null)
                        {
                            return friendlyAppName.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return null;
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
            Process.Start("explorer", _file.outputFileName.Replace(new FileInfo(_file.outputFileName).Name, ""));
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());
        }

        private async void bntPreview_Click(object sender, EventArgs e)
        {
            if (_file.outputFileName.EndsWith(".pdf"))
            {
                MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri(_file.outputFileName)));
            }
            else if (_file.outputFileName.EndsWith(".mp3") || _file.outputFileName.EndsWith(".wav"))
            {
                if(config.Default.openMediaIn != "buildIn")
                {
                    MessageBox.Show("You need to enable this feature first because its still in development.","Activation required",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                var para = await streaming.MusikPlayer.Core.MusicPlayerParameters.Get(_file.outputFileName);
                var mediaInstance = streaming.MusikPlayer.Forms.uiPlayer.Instance(para, true);
                MainHost.Instance().OpenInApp(mediaInstance);
            }
            else
            {
                foreach (var plugin in MainHost.Instance().manager.CurrentPlugins)
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

                        plugin.Execute(new PluginParameters()
                        {
                            Context = list,
                            themeManager = MainHost.Instance()._thManager,
                        });
                        MainHost.Instance().OpenInApp(plugin.PluginInterface);
                    }
                }
            }
        }
    }
}
