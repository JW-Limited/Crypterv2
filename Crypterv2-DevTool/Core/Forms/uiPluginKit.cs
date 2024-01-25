using Crypterv2.DevTool.Core;
using Crypterv2.DevTool.Core.Forms;
using Crypterv2.DevTool.Core.Plugins;
using Crypterv2.DevTool.Core.Plugins.Config;
using Crypterv2.DevTool.Core.Types;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System.Collections.ObjectModel;
using System.Text;

namespace Crypterv2_DevTool.Core.Forms
{
    public partial class uiPluginKit : Form
    {
        public static string ChannelLog;
        public static string PluginDevState;
        public static List<PluginFeature> PluginFeatures = new List<PluginFeature>();
        public static List<CapabilityInfo> Features { get; set; }

        public PluginManagerv2 PluginBaseManager = null;

        public LILO_Packager.v2.Core.History.DatabaseHandling dataHandler = new LILO_Packager.v2.Core.History.DatabaseHandling();
        public ObservableCollection<string> Dependencies = new ObservableCollection<string>();
        private PackageManager PackageManager { get; set; }

        public object SelectedPlugin { get; set; }
        public string PluginIcon { get; set; }
        public string OpenedDirectory = string.Empty;

        private static uiPluginKit _instance;
        public static uiPluginKit Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new uiPluginKit();
            }
            return _instance;
        }



        private uiPluginKit()
        {
            InitializeComponent();

            this.FormClosing += (s, e) =>
            {
                _instance = null;
            };
        }

        public string GetShortDirectoryName(string value)
        {
            var dirinfo = new DirectoryInfo(value);
            return dirinfo.Name;
        }

        private void uiTestPlugin_Load(object sender, EventArgs e)
        {
            lblDirectory.Text = "Select Directory";
            if (PluginTestConfig.Default.recentDirectory is not null)
            {
                Task.Run(async () =>
                {

                    this.Invoke(() =>
                    {
                        lblMessageText.Text = "Searching for Plugins...";
                        pnlLoading.Visible = true;
                    });

                    PluginBaseManager = new PluginManagerv2(PluginTestConfig.Default.recentDirectory);
                    await PluginBaseManager.Scan();
                    lblDirectory.Text = "/" + GetShortDirectoryName(PluginTestConfig.Default.recentDirectory);

                    try
                    {
                        if (PluginBaseManager.Pluginsv1.Count > 0 || PluginBaseManager.PluginsV2.Count > 0)
                        {
                            foreach (var item in PluginBaseManager.PluginsV2.Where(x => x is not null))
                            {
                                cmbState.Items.Add(item.Name);
                            }

                            foreach (var item in PluginBaseManager.Pluginsv1.Where(x => !cmbState.Items.Contains(x.Name)))
                            {
                                cmbState.Items.Add(item.Name);
                            }

                            cmbState.SelectedItem = cmbState.Items[0];

                            var plugin = PluginBaseManager.PluginsV2.FirstOrDefault(x => x?.Name == cmbState.Items[0] as string, null);
                            if (plugin is not null)
                            {
                                pluginUi.PluginName = plugin.Name;
                                pluginUi.PluginDescription = plugin.Description;
                                pluginUi.PluginVersion = plugin.Version;
                                this.SelectedPlugin = plugin;

                                SetPluginConfigs(plugin.Name);
                                ResetMessageText();
                            }
                            else
                            {
                                var pluginv1 = PluginBaseManager.Pluginsv1.First(x => x?.Name == cmbState.Items[0] as string);
                                pluginUi.PluginName = pluginv1.Name;
                                pluginUi.PluginDescription = pluginv1.Description;
                                pluginUi.PluginVersion = pluginv1.Version;
                                this.SelectedPlugin = pluginv1;

                                SetPluginConfigs(pluginv1.Name);
                                ResetMessageText();
                            }

                        }
                        else
                        {
                            this.Invoke(() =>
                            {
                                MessageBox.Show("We didnt found any Plugins", "Crypterv2-DevTool");
                            });

                            ResetMessageText();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException + ex.StackTrace + ex.Source + DevToolCodes.ToString(DevToolCodes.UnknownError), "PluginManager");
                        ResetMessageText();
                    }
                });
            }
                
                else
                {
                    this.Invoke(() =>
                    {
                        ResetMessageText();
                    });
                }
        }

        private void SetPluginConfigs(string name)
        {
            var configManager = new PluginConfigManager(name, null);
            var configs = configManager.TryGetExistingConfigs();

            if (configs.Success)
            {
                if (File.Exists(configs.PluginIcon))
                {
                    using (var fileStream = new StreamReader(configs.PluginIcon))
                    {
                        var icon = Bitmap.FromStream(fileStream.BaseStream);
                        PluginIcon = configs.PluginIcon;
                        pluginUi.PluginIcon = icon;
                    };
                }

                pluginUi.PluginName = configs.PluginConfig.Name;
                pluginUi.PluginDescription = configs.PluginConfig.Description;
                pluginUi.PluginVersion = configs.PluginConfig.Version;

                ((IPluginBase)SelectedPlugin).Version = configs.PluginConfig.Version;
                ((IPluginBase)SelectedPlugin).Name = configs.PluginConfig.Name;

                ChannelLog = configs.PluginConfig.Changes;
                PluginDevState = configs.PluginConfig.State;

                foreach (var item in configs.Dependencies)
                {
                    this.Dependencies.Add(item.FilePath);
                }
            }
        }

        public void ResetMessageText()
        {
            this.Invoke(() =>
            {
                lblMessageText.Text = "Creating youre Plugin...";
                pnlLoading.Visible = false;
            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var ofd = new FolderBrowserDialog()
            {
                AddToRecent = true,
                OkRequiresInteraction = true,
                ShowHiddenFiles = true,
                ShowPinnedPlaces = true,
            };


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() =>
                {
                    this.Invoke(async() =>
                    {
                        lblMessageText.Text = "Searching for Plugins...";
                        pnlLoading.Visible = true;

                        PluginBaseManager = new PluginManagerv2(ofd.SelectedPath);
                        await PluginBaseManager.Scan();
                        lblDirectory.Text = "/" + GetShortDirectoryName(ofd.SelectedPath);

                        try
                        {
                            if (PluginBaseManager.Pluginsv1.Count > 0 || PluginBaseManager.PluginsV2.Count > 0)
                            {
                                Console.WriteLine("Filling in v2");

                                foreach (var item in PluginBaseManager.PluginsV2.Where(x => x is not null))
                                {
                                    cmbState.Items.Add(item.Name);
                                }

                                Console.WriteLine("Filling in v1");

                                foreach (var item in PluginBaseManager.Pluginsv1.Where(x => !cmbState.Items.Contains(x.Name)))
                                {
                                    cmbState.Items.Add(item.Name);
                                }

                                cmbState.SelectedItem = cmbState.Items[0];

                                var plugin = PluginBaseManager.PluginsV2.FirstOrDefault(x => x?.Name == cmbState.Items[0] as string, null);
                                if (plugin is not null)
                                {
                                    pluginUi.PluginName = plugin.Name;
                                    pluginUi.PluginDescription = plugin.Description;
                                    pluginUi.PluginVersion = plugin.Version;
                                    this.SelectedPlugin = plugin;

                                    SetPluginConfigs(plugin.Name);
                                    ResetMessageText();
                                }
                                else
                                {
                                    var pluginv1 = PluginBaseManager.Pluginsv1.First(x => x?.Name == cmbState.Items[0] as string);
                                    pluginUi.PluginName = pluginv1.Name;
                                    pluginUi.PluginDescription = pluginv1.Description;
                                    pluginUi.PluginVersion = pluginv1.Version;
                                    this.SelectedPlugin = pluginv1;

                                    SetPluginConfigs(pluginv1.Name);
                                    ResetMessageText();
                                }

                                PluginTestConfig.Default.recentDirectory = ofd.SelectedPath;
                                PluginTestConfig.Default.Save();
                            }
                            else
                            {
                                this.Invoke(() =>
                                {
                                    MessageBox.Show("We didnt found any Plugins", "Crypterv2-DevTool");
                                });

                                ResetMessageText();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ex.InnerException + ex.StackTrace + ex.Source + DevToolCodes.ToString(DevToolCodes.UnknownError), "PluginManager");
                            ResetMessageText();
                        }
                    });
                });

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                IPluginBase neededPlugin = ((IPluginBase)SelectedPlugin);

                if (neededPlugin is not null)
                {
                    neededPlugin.PluginInterface.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It seems like the Plugin has a problem: \n\n" + ex.Message, "PluginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Pack_Click(object sender, EventArgs e)
        {

            pnlLoading.Visible = true;

            _ = Task.Run((Func<Task?>)(async () =>
            {
                try
                {
                    IPluginBase neededPlugin = ((IPluginBase)SelectedPlugin);

                    if (neededPlugin is not null)
                    {
                        PluginBaseManager.pluginPaths.TryGetValue(neededPlugin, out string dllFile);
                        var featureList = new List<CapabilityInfo>();

                        foreach (var feature in PluginFeatures)
                        {
                            featureList.Add(new CapabilityInfo()
                            {
                                Name = feature.Description,
                                Arguments = new List<ArgumentInfo>()
                                {
                                    feature.ArgumentInfo
                                }
                            });
                        }

                        PackageManager = new PackageManager(
                        new Crypterv2.DevTool.Core.Plugins.Types.PluginPackage(
                            dllFile,
                            "",
                            neededPlugin,
                            new LILO_Packager.v2.Plugins.ThirdParty.Types.PluginInformation()
                            {
                                Name = neededPlugin.Name,
                                Capabilities = featureList,
                                Version = new VersionInfo() { Number = neededPlugin.Version, ReleaseDate = DateTime.UtcNow.ToShortDateString(), Changes = ChannelLog, State = PluginDevState },
                            },
                            PluginTestConfig.Default.recentDirectory,
                            Dependencies)

                        {
                            IconFile = PluginIcon,

                        });
                        var progressCallback = new Progress<PackageManagerProgress>(progress =>
                        {
                            this.Invoke(() =>
                            {
                                this.progress.Visible = true;
                                this.Text = "Crypterv2 - Packaging: " + progress.Percentage + " - Time Left" + progress.EstimatedTimeRemaining.ToString();
                            });

                        });

                        try
                        {
                            PackageManager.Progress = progressCallback;
                            var response = await PackageManager.CreatePackage();

                            if (response.Success)
                            {
                                this.Invoke(() =>
                                {
                                    pnlLoading.Visible = false;

                                    MainHost.GetInstance().OpenInApp(new uiPluginPackageView(new Crypterv2.DevTool.Core.Plugins.Types.PluginPackage(
                            dllFile,
                            "",
                            neededPlugin,
                            new LILO_Packager.v2.Plugins.ThirdParty.Types.PluginInformation()
                            {
                                Name = neededPlugin.Name,
                                Capabilities = featureList,
                                Version = new VersionInfo() { Number = neededPlugin.Version, ReleaseDate = DateTime.UtcNow.ToShortDateString(), Changes = ChannelLog, State = PluginDevState },
                            },
                            PluginTestConfig.Default.recentDirectory,
                            Dependencies)), "Success", MainHost.ChildrenUse.Auth);

                                    this.progress.Visible = false;
                                });
                            }

                            else if (response.IsError)
                            {
                                SetLocalError(response.Message, "ExternHandledException");
                            }
                        }
                        catch (Exception ex)
                        {
                            SetLocalError("Error while Idle:\n\n" + ex.Message + DevToolCodes.ToString(DevToolCodes.UnknownError), "ProcessError");
                        }
                    }

                    else
                    {
                        SetLocalError("The plugin entry was null. Please reload the plugin.", "PluginError");
                    }
                }
                catch (Exception ex)
                {
                    SetLocalError("It seems like the Plugin has a problem: \n\n" + ex.Message, "PluginError");
                }
            }));
        }

        public void SetLocalError(string Message, string header)
        {
            this.Invoke(() =>
            {
                this.progress.Visible = false;
                this.pnlLoading.Visible = false;
                MessageBox.Show(Message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }

        private void cmbPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPluginBase neededPlugin = PluginBaseManager.Pluginsv1.First(x => x.Name == cmbState.SelectedItem as string);

            if (neededPlugin != null)
            {
                pluginUi.PluginName = neededPlugin.Name;
                pluginUi.PluginDescription = neededPlugin.Description;
                pluginUi.PluginVersion = neededPlugin.Version;

                this.SelectedPlugin = neededPlugin;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntDependiecies(object sender, EventArgs e)
        {
            Dependencies = uiDialogFiles.GetHandle(Dependencies).GetDependencies();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SelectedPlugin = new uiDialogInfos(((IPluginBase)SelectedPlugin)).GetInfos();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Plugin Icon|*.png;*.jpg;*.jpeg;*.ico";
            ofd.Multiselect = false;
            ofd.Title = "Select Plugin Icon";
            ofd.AutoUpgradeEnabled = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PluginIcon = ofd.FileName;

                using (var stream = new StreamReader(ofd.FileName))
                {
                    pluginUi.PluginIcon = Bitmap.FromStream(stream.BaseStream);
                }

                var exConfigManager = new PluginConfigManager(((IPluginBase)SelectedPlugin).Name, new Crypterv2.DevTool.Core.Plugins.Types.PluginConfig()
                {
                    Name = ((IPluginBase)SelectedPlugin).Name,
                    Description = ((IPluginBase)SelectedPlugin).Description,
                    Version = ((IPluginBase)SelectedPlugin).Version,
                    State = PluginDevState,
                    Changes = ChannelLog,
                    PluginIcon = PluginIcon
                });

                exConfigManager.SavePluginConfig();

                pluginUi.PluginName = ((IPluginBase)SelectedPlugin).Name;
                pluginUi.PluginVersion = ((IPluginBase)SelectedPlugin).Version;
            }


        }

        private void dynamicToggleButton2_Clicked(object sender, EventArgs e)
        {
            bntBuild.Enabled = togglePirate.Checked && togglePublish.Checked;
        }

        private void togglePublish_Clicked(object sender, EventArgs e)
        {
            bntBuild.Enabled = togglePirate.Checked && togglePublish.Checked;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            PluginTestConfig.Default.recentDirectory = null;
            PluginTestConfig.Default.Save();
        }
    }
}
