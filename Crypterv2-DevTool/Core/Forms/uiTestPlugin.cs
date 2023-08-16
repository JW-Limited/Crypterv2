using LILO_Packager.v2.plugins.Model;
using LILO_Packager.v2.plugins.PluginCore;
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
        private static uiTestPlugin _instance;
        public static uiTestPlugin Instance()
        {
            if (_instance == null)
            {
                _instance = new uiTestPlugin();
            }
            return _instance;
        }


        private PluginManager manager = null;
        public LILO_Packager.v2.Core.History.DatabaseHandling dataHandler = new LILO_Packager.v2.Core.History.DatabaseHandling();
        public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();

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
            if(PluginTestConfig.Default.recentDirectory is not "null")
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
                        }


                        MessageBox.Show("We found Plugins and loaded them:\n\n" + stringBuilder.ToString() + "\n", "Crypterv2-DevTool");
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
                lblDirectory.Text = ofd.SelectedPath;

                manager = new PluginManager(ofd.SelectedPath);

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
                        }

                        PluginTestConfig.Default.recentDirectory = ofd.SelectedPath;
                        PluginTestConfig.Default.Save();

                        MessageBox.Show("We found Plugins and loaded them:\n\n" + stringBuilder.ToString() + "\n", "Crypterv2-DevTool");
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
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PluginEntry neededPlugin = null;

            foreach (var plug in plugins)
            {
                if(plug.Name == cmbPlugins.SelectedItem)
                {
                    neededPlugin = plug;
                }
            }

            if (neededPlugin is not null)
            {
                OpenInApp(neededPlugin.form, "Test", ChildrenUse.Auth);
            }
        }

        public enum ChildrenUse
        {
            Auth,
            WebView,
            NormalForm
        }



        private Form currentOpenedApp;

        /// <summary>
        /// This Method accpets a WinForm object and 
        /// displays it over all controls with help of
        /// a Panel
        /// </summary>
        /// <param name="children">
        /// The Form Object
        /// </param>
        /// <param name="FormName">
        /// The displayed Formname
        /// </param>
        /// <param name="usage">
        /// The Mode and Accessability clarifier
        /// </param>

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
