using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (_instance == null)
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

        private void uiTestPlugin_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lblDirectory.Text = "Select Directory";

                if (PluginTestConfig.Default.recentDirectory is not "null")
                {
                    manager = new PluginManager(PluginTestConfig.Default.recentDirectory);
                    lblDirectory.Text = PluginTestConfig.Default.recentDirectory;

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
                            }

                            PluginTestConfig.Default.recentDirectory = ofd.SelectedPath;
                            PluginTestConfig.Default.Save();

                            lblDirectory.Text = ofd.SelectedPath;

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
                    this.Size = new System.Drawing.Size(neededPlugin.form.Size.Width + 10, neededPlugin.form.Size.Height + 10);
                    OpenInApp(neededPlugin.form, "Test", ChildrenUse.Auth);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("It seems like the Plugin has a problem: \n\n" + ex.Message,"PluginError",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
