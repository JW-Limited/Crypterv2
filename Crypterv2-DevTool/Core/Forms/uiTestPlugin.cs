using Crypterv2.DevTool.Core;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Collections.ObjectModel;
using System.Text;

namespace Crypterv2_DevTool.Core.Forms
{
    public partial class uiTestPlugin : Form
    {
        private PluginManager manager = null;
        public LILO_Packager.v2.Core.History.DatabaseHandling dataHandler = new LILO_Packager.v2.Core.History.DatabaseHandling();
        public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();

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
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
