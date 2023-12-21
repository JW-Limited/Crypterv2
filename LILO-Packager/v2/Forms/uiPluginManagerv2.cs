using LILO_Packager.v2.Controls;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPluginManagerv2 : Form
    {
        public uiPluginManagerv2()
        {
            InitializeComponent();

            this.FormClosing += (s, e) =>
            {
                e.Cancel = true;
                this.Hide();
            };
        }

        private static Lazy<uiPluginManagerv2> _instance = new Lazy<uiPluginManagerv2>(() => new uiPluginManagerv2());
        public static uiPluginManagerv2 Instance => _instance.Value;
        public static IPluginBase SelectedPlugin;

        public async Task SetPlugin(IPluginBase entry)
        {
            try
            {
                SelectedPlugin = entry;
                var interfacev2 = MainHost.Instance()._pluginManager.PluginsV2.First(k => k.Name == entry.Name);

                pnlPluginIcon.BackgroundImage = interfacev2.PluginIcon;
                lblPluginName.Text = entry.Name;
                lblDescription.Text = entry.Description;
                lblAuthor.Text = PluginID.IDtoString(interfacev2.ID);
                lblCompany.Text = interfacev2.Company;
                lblVersion.Text = interfacev2.Version;

                pnlPermissions.Controls.Clear();

                foreach (var item in interfacev2.Permissions)
                {
                    await AddPermission(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This plugin doesnt support this Feature.", "Manifest Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uiPluginManagerv2_Load(object sender, EventArgs e)
        {
            foreach (var plug in MainHost.Instance()._pluginManager.Pluginsv1)
            {
                AddToPluginList(plug);
            }
        }

        public int Height = 0;
        public int Height_P = 0;

        private Task AddPermission(Permission permission)
        {
            var uiPermissionElement = new DynamikPermissionView()
            {
                PermissionDescription = permission.Description,
                PermissionName = permission.Type.ToString()
            };

            pnlPermissions.Controls.Add(uiPermissionElement);

            uiPermissionElement.Show();

            uiPermissionElement.Location = new Point(20, Height_P);
            uiPermissionElement.Width = pnlPermissions.Width - 50;
            uiPermissionElement.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            Height_P += uiPermissionElement.Height + 25;

            return Task.CompletedTask;
        }

        public Task AddToPluginList(IPluginBase entry)
        {
            var uiElement = new DynamikPluginListItem();
            uiElement.PluginName = entry.Name;
            uiElement.PluginVersion = entry.Version;
            uiElement.Plugin = entry;

            pnlPlugins.Controls.Add(uiElement);
            pnlPlugins.Show();

            uiElement.Location = new Point(0, Height);
            uiElement.Width = pnlPlugins.Width;
            uiElement.Height = 72;

            Height += uiElement.Height + 20;

            return Task<Task>.CompletedTask;
        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            Program.InstanceCacheContainer.Resolve<ILILOMainHost>().OpenInApp(uiPluginStore.Instance);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (SelectedPlugin is not null)
                {
                    var PluginBasev2 = MainHost.Instance()._pluginManager.PluginsV2.First(k => k.Name == SelectedPlugin.Name);

                    var web = uiWebView.Instance(new Uri(PluginBasev2.DocumentationLink));
                    web.Text = PluginBasev2.Name;
                    web.StartPosition = FormStartPosition.CenterParent;
                    web.ControlBox = true;
                    web.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("This plugin doesnt support this Feature.", "Manifest Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bntDeinstall(object sender, EventArgs e)
        {

        }
    }
}
