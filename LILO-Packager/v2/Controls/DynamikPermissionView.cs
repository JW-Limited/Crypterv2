using LILO_Packager.v2.Forms;
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

namespace LILO_Packager.v2.Controls
{
    public partial class DynamikPermissionView : UserControl
    {
        public DynamikPermissionView()
        {
            InitializeComponent();
        }

        public bool EnabledState { get => toggleGrantPermission.Checked; set => toggleGrantPermission.Checked = value; }
        public String PermissionName { get => lblPluginName.Text; set => lblPluginName.Text = value; }
        public String PermissionDescription { get => lblDescription.Text; set => lblDescription.Text = value; }
        public Permission Permission { get; set; }

        private async void toggleGrantPermission_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private async void toggleGrantPermission_Click(object sender, EventArgs e)
        {
            await uiPluginManagerv2.Instance.SetPermissionState(Permission, EnabledState);
        }
    }
}
