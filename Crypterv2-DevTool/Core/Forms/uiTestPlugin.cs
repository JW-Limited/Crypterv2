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
        private PluginManager manager = null;
        public LILO_Packager.v2.Core.History.DatabaseHandling dataHandler = new LILO_Packager.v2.Core.History.DatabaseHandling();
        public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();
        private PackageManager PackageManager { get; set; }
        public string OpenedDirectory = string.Empty;
        public static string ChannelLog;
        public static string PluginDevState;
        public static List<PluginFeature> PluginFeatures = new List<PluginFeature>();
        public static List<LILO_Packager.v2.Plugins.ThirdParty.Types.CapabilityInfo> Features { get; set; }
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
                                cmbPlugins.Items.Add(item.Name);
                                cmbPlugins.SelectedItem = item.Name;

                                lblProductName.Text = item.Name;
                                lblPluginInfo.Text = item.Description;
                                lblVersion.Text = item.Version;
                                this.SelectedPlugin = item;
                            };
                        }
                        else
                        {
                            MessageBox.Show("We didnt found any Plugins", "Crypterv2-DevTool");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                Task.Run(() =>
                {
                    plugins.Clear();
                    lblDirectory.Text = "Searching...";
                    cmbPlugins.Items.Clear();
                    cmbPlugins.Text = string.Empty;
                    manager = new PluginManager(ofd.SelectedPath);

                    try
                    {
                        if (manager.CurrentPlugins.Count > 0)
                        {
                            foreach (var ele in manager.CurrentPlugins)
                            {
                                PluginEntry ent = new PluginEntry(ele);
                                plugins.Add(ent);
                                cmbPlugins.Items.Add(ent.Name);
                                cmbPlugins.SelectedItem = ent.Name;

                                lblProductName.Text = ent.Name;
                                lblPluginInfo.Text = ent.Description;
                                lblVersion.Text = ent.Version;
                                this.SelectedPlugin = ent;
                            }

                            PluginTestConfig.Default.recentDirectory = ofd.SelectedPath;
                            PluginTestConfig.Default.Save();

                            lblDirectory.Text = "/" + GetShortDirectoryName(ofd.SelectedPath);

                        }
                        else
                        {
                            MessageBox.Show("We didnt found any Plugins", "Crypterv2-DevTool");
                            lblDirectory.Text = "Select directory.";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                PluginEntry neededPlugin = null;

                foreach (var plug in plugins)
                {
                    if (plug.Name == cmbPlugins.SelectedItem)
                    {
                        neededPlugin = plug;
                    }
                }

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
                                OkDialog.Show(response.Message, response.Status);
                                this.Invoke(() => { this.progress.Visible = false; });
                            }

                            else if (response.IsError)
                            {
                                MessageBox.Show("The prozess didnt finished as expected:\n\n" + response.Message + " - Prozess ended with:" + response.EndingCode.ToString("X"), response.Status, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Invoke(() => { this.progress.Visible = false; });
                            }
                        }
                        catch (Exception ex)
                        {
                            this.Invoke(() => { this.progress.Visible = false; });
                            MessageBox.Show("Error while Idle:\n\n" + ex.Message, "Error");
                        }


                    }

                    else
                    {
                        this.Invoke(() =>
                        {
                            this.Invoke(() => { this.progress.Visible = false; });
                            MessageBox.Show("The plugin entry was null. Please reload the plugin.", "PluginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(() => { this.progress.Visible = false; });
                    MessageBox.Show("It seems like the Plugin has a problem: \n\n" + ex.Message, "PluginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }



        private Form currentOpenedApp;

        public void OpenInApp(Form children, string FormName = null, ChildrenUse usage = ChildrenUse.WebView)
        {

            if (children == currentOpenedApp) return;

            if (currentOpenedApp is not null)
            {
                currentOpenedApp.Close();
            }


            this.IsMdiContainer = true;
            this.BackColor = Color.White;

            children.MdiParent = this;
            pnlChild.Controls.Add(children);
            pnlChild.Dock = DockStyle.Fill;
            pnlChild.BringToFront();

            if (usage == ChildrenUse.Auth)
            {
                children.MaximizeBox = false;
                children.MinimizeBox = false;
                children.ControlBox = false;
                children.FormBorderStyle = FormBorderStyle.None;
            }
            else if (usage == ChildrenUse.WebView)
            {
                children.FormBorderStyle = FormBorderStyle.Sizable;
                children.MaximizeBox = false;
                children.MinimizeBox = false;
            }
            else if (usage == ChildrenUse.NormalForm)
            {
                children.FormBorderStyle = FormBorderStyle.Sizable;
                children.MaximizeBox = false;
                children.MinimizeBox = false;
                this.Size = children.Size;
            }

            children.Dock = DockStyle.Fill;

            if (FormName is not null or "") children.Text = FormName;


            children.Show();

            currentOpenedApp = children;

            currentOpenedApp.FormClosing += (sender, e) =>
            {
                this.IsMdiContainer = false;
                this.BackColor = Color.White;
                pnlChild.Dock = DockStyle.None;
                pnlChild.Size = new Size(1, 1);
            };
        }

        private void cmbPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            PluginEntry neededPlugin = null;

            foreach (var plug in plugins)
            {
                if (plug.Name == cmbPlugins.SelectedItem)
                {
                    neededPlugin = plug;
                }
            }

            if (neededPlugin != null)
            {
                lblProductName.Text = neededPlugin.Name;
                lblPluginInfo.Text = neededPlugin.Description;
                lblVersion.Text = neededPlugin.Version;

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
                pnlIcon.BackgroundImage = Bitmap.FromFile(ofd.FileName);
            }
        }

        private void c(object sender, EventArgs e)
        {

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
