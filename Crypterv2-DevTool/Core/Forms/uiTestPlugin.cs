using Crypterv2.DevTool.Core;
using Crypterv2.DevTool.Core.Forms;
using Crypterv2.DevTool.Core.Plugins;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System.Collections.ObjectModel;
using System.Text;

namespace Crypterv2_DevTool.Core.Forms
{
    public partial class uiTestPlugin : Form
    {
        public PluginManager manager = null;
        public LILO_Packager.v2.Core.History.DatabaseHandling dataHandler = new LILO_Packager.v2.Core.History.DatabaseHandling();
        public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();
        private PackageManager PackageManager { get; set; }
        public string OpenedDirectory = string.Empty;
        public static string ChannelLog;
        public static string PluginDevState;
        public static List<PluginFeature> PluginFeatures = new List<PluginFeature>();
        public static List<CapabilityInfo> Features { get; set; }
        public ObservableCollection<string> Dependencies = new ObservableCollection<string>();
        public string PluginIcon { get; set; }
        public PluginEntry SelectedPlugin { get; set; }

        private static uiTestPlugin _instance;
        public static uiTestPlugin Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new uiTestPlugin();
            }
            return _instance;
        }



        private uiTestPlugin()
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

            Task.Run(() =>
            {
                lblDirectory.Text = "Select Directory";

                if (PluginTestConfig.Default.recentDirectory is not "null")
                {
                    this.Invoke(() =>
                    {
                        lblMessageText.Text = "Searching for Plugins...";
                        pnlLoading.Visible = true;
                    });

                    manager = new PluginManager(PluginTestConfig.Default.recentDirectory);
                    lblDirectory.Text = "/" + GetShortDirectoryName(PluginTestConfig.Default.recentDirectory);

                    try
                    {
                        if (manager.CurrentPlugins.Count > 0)
                        {
                            foreach (var ele in manager.CurrentPlugins)
                            {
                                PluginEntry ent = new PluginEntry(ele);
                                plugins.Add(ent);
                            }

                            StringBuilder stringBuilder = new StringBuilder();

                            foreach (var item in plugins)
                            {
                                stringBuilder.Append($"Plugin : {item.Name}\n" +
                                                     $"Description : {item.Description}\n" +
                                                     $"Version : {item.Version}");
                                cmbState.Items.Add(item.Name);
                                cmbState.SelectedItem = item.Name;

                                pluginUi.PluginName = item.Name;
                                pluginUi.PluginDescription = item.Description;
                                pluginUi.PluginVersion = item.Version;
                                this.SelectedPlugin = item;
                            };

                            this.Invoke(() =>
                            {
                                lblMessageText.Text = "Creating youre Plugin...";
                                pnlLoading.Visible = false;
                            });
                        }
                        else
                        {
                            MessageBox.Show("We didnt found any Plugins", "Crypterv2-DevTool");

                            this.Invoke(() =>
                            {
                                lblMessageText.Text = "Creating youre Plugin...";
                                pnlLoading.Visible = false;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                        this.Invoke(() =>
                        {
                            lblMessageText.Text = "Creating youre Plugin...";
                            pnlLoading.Visible = false;
                        });
                    }
                }
                else
                {
                    this.Invoke(() =>
                    {
                        lblMessageText.Text = "Creating youre Plugin...";
                        pnlLoading.Visible = false;
                    });
                }
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
                pnlLoading.Visible = true;
                lblMessageText.Text = "Searching for Plugins...";

                Task.Run(() =>
                {
                   
                    plugins.Clear();
                    lblDirectory.Text = "Searching...";
                    cmbState.Items.Clear();
                    cmbState.Text = string.Empty;
                    manager = new PluginManager(ofd.SelectedPath);

                    try
                    {
                        if (manager.CurrentPlugins.Count > 0)
                        {
                            foreach (var ele in manager.CurrentPlugins)
                            {
                                PluginEntry ent = new PluginEntry(ele);
                                plugins.Add(ent);
                                cmbState.Items.Add(ent.Name);
                                cmbState.SelectedItem = ent.Name;

                                pluginUi.PluginName = ent.Name;
                                pluginUi.PluginDescription = ent.Description;
                                pluginUi.PluginVersion = ent.Version;
                                this.SelectedPlugin = ent;
                            }

                            PluginTestConfig.Default.recentDirectory = ofd.SelectedPath;
                            PluginTestConfig.Default.Save();

                            lblDirectory.Text = "/" + GetShortDirectoryName(ofd.SelectedPath);

                            pnlLoading.Visible = false;
                        }
                        else
                        {
                            this.Invoke(() =>
                            {
                                pnlLoading.Visible = false;
                                lblMessageText.Text = "Creating youre Plugin...";
                                MessageBox.Show("We didnt found any Plugins", "Crypterv2-DevTool");
                                lblDirectory.Text = "Select directory.";
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(() =>
                        {
                            MessageBox.Show(ex.Message);
                            pnlLoading.Visible = false;
                            lblMessageText.Text = "Creating youre Plugin...";
                        });
                    }
                });

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                PluginEntry neededPlugin = SelectedPlugin;

                if (neededPlugin is not null)
                {
                    neededPlugin.form.Show();
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

            _ = Task.Run(async () =>
            {
                try
                {
                    PluginEntry neededPlugin = SelectedPlugin;

                    if (neededPlugin is not null)
                    {
                        manager.pluginPaths.TryGetValue(neededPlugin.PluginBase, out string dllFile);
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

                            if (response.IsSuccess)
                            {
                                this.Invoke(() => {
                                    pnlLoading.Visible = false;
                                    OkDialog.Show(response.Message, response.Status);
                                    this.progress.Visible = false; });
                            }

                            else if (response.IsError)
                            {
                                this.Invoke(() => {
                                    pnlLoading.Visible = false;
                                    this.progress.Visible = false;
                                    MessageBox.Show("The prozess didnt finished as expected:\n\n" + response.Message + " - Prozess ended with:" + response.EndingCode.ToString("X"), response.Status, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            this.Invoke(() => { this.progress.Visible = false;
                                pnlLoading.Visible = false;
                                MessageBox.Show("Error while Idle:\n\n" + ex.Message, "Error");
                            });
                        }
                    }

                    else
                    {
                        this.Invoke(() =>
                        {
                            this.Invoke(() => { this.progress.Visible = false;

                                pnlLoading.Visible = false;
                                MessageBox.Show("The plugin entry was null. Please reload the plugin.", "PluginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            });});
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(() => { 
                        this.progress.Visible = false;
                        pnlLoading.Visible = false;
                        MessageBox.Show("It seems like the Plugin has a problem: \n\n" + ex.Message, "PluginError", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                    
                }
            });
        }

        private void cmbPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            PluginEntry neededPlugin = null;

            foreach (var plug in plugins)
            {
                if (plug.Name == cmbState.SelectedItem)
                {
                    neededPlugin = plug;
                }
            }

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
            SelectedPlugin = new uiDialogInfos(SelectedPlugin).GetInfos();

            var exConfigManager = new PluginConfigManager(SelectedPlugin.Name, new Crypterv2.DevTool.Core.Plugins.Types.PluginConfig()
            {
                Name = SelectedPlugin.Name,
                Description = SelectedPlugin.Description,
                Version = SelectedPlugin.Version,
                State = PluginDevState,
                Changes = ChannelLog,
                PluginIcon = PluginIcon
            });

            exConfigManager.SavePluginConfig();

            pluginUi.PluginName = SelectedPlugin.Name;
            pluginUi.PluginVersion = SelectedPlugin.Version;
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Plugin Icon|*.png;*.jpg;*.jpeg";
            ofd.Multiselect = false;
            ofd.Title = "Select Plugin Icon";
            ofd.AutoUpgradeEnabled = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PluginIcon = ofd.FileName;
                pluginUi.PluginIcon = Bitmap.FromFile(ofd.FileName);
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
    }
}
