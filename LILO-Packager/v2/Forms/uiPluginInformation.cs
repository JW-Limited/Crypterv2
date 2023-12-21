using LILO_Packager.v2.Controls;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPluginInformation : Form
    {
        public uiPluginInformation(PluginEntry entry)
        {
            InitializeComponent();

            this.entry = entry;
        }

        public int Height = 0;

        public bool AcceptedPermissions = true;
        public readonly PluginEntry entry;
        public IPluginBasev2 PluginBasev2;

        private async void uiPluginInformation_Load(object sender, EventArgs e)
        {
            lblDescription.Text = entry.Description;
            lblPluginName.Text = entry.Name;

            try
            {
                PluginBasev2 = MainHost.Instance()._pluginManager.PluginsV2.First(k => k.Name == entry.Name);

                foreach (var per in PluginBasev2.Permissions)
                {
                    await AddPermission(per);
                }

                if (PluginBasev2.ShellIntegration is not null)
                {
                    await AddPermission(
                    new Permission()
                    {
                        Type = PermissionType.AccessToMainHostAPI,
                        Description = "Shell Integration."

                    });
                }

                pnlPluginIcon.BackgroundImage = PluginBasev2.PluginIcon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("This plugin does not support the latest Manfiest.", "Pluginmanager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public static DialogResult ShowDialog(PluginEntry entry)
        {
            var uiInstance = new uiPluginInformation(entry);
            uiInstance.ShowDialog();

            if (uiInstance.AcceptedPermissions)
            {
                return DialogResult.OK;
            }
            else
            {
                return DialogResult.Abort;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AcceptedPermissions = true;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Task AddPermission(Permission permission)
        {
            var uiPermissionElement = new DynamikPermissionView()
            {
                PermissionDescription = permission.Description,
                PermissionName = permission.Type.ToString()
            };

            pnlPermissions.Controls.Add(uiPermissionElement);

            uiPermissionElement.Show();

            uiPermissionElement.Location = new Point(20, Height);
            uiPermissionElement.Width = pnlPermissions.Width - 50;
            Height += uiPermissionElement.Height + 25;

            return Task.CompletedTask;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var web = uiWebView.Instance(new Uri(PluginBasev2.DocumentationLink));
            web.Text = PluginBasev2.Name;
            web.StartPosition = FormStartPosition.CenterParent;
            web.ControlBox = true;
            web.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
