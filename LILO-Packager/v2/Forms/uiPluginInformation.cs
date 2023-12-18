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

        public readonly PluginEntry entry;

        private async void uiPluginInformation_Load(object sender, EventArgs e)
        {
            lblDescription.Text = entry.Description;
            lblPluginName.Text = entry.Name;

            try
            {
                var pluginInterface = MainHost.Instance()._pluginManager.PluginsV2.First(k => k.Name == entry.Name);

                foreach (var per in pluginInterface.Permissions)
                {
                    await AddPermission(per);
                }

                if(pluginInterface.ShellIntegration is not null)
                {
                    await AddPermission(new Permission()
                    {
                        Type = PermissionType.AccessToMainHostAPI,
                        Description = "Shell Integration."

                    });
                }

                pnlPluginIcon.BackgroundImage = pluginInterface.PluginIcon;
            }
            catch(Exception ex)
            {
                MessageBox.Show("This plugin does not support the latest Manfiest.","Pluginmanager",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
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
            uiPermissionElement.Width = pnlPermissions.Width -50;
            Height += uiPermissionElement.Height + 25;

            return Task.CompletedTask;
        }
    }
}
