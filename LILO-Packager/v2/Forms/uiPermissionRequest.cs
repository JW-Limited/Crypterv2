using LILO_Packager.v2.Plugins.Internal;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Collections.ObjectModel;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPermissionRequest : Form
    {
        private readonly object _dataLock = new object();
        private byte _changedPermissionState = 0;

        public uiPermissionRequest(PluginData.PermissionSet permission, PluginData data)
        {
            InitializeComponent();

            if (permission.Equals(null) || permission is null || data is null) throw new ArgumentNullException(nameof(permission));
            if (permission.Enabled) throw new AccessAlreadyGrantedException();
            lblPermissionName.Text = permission.Permission.Type.ToString();
            lblDescription.Text = permission.Permission.Description;
           
        }

        public async Task<byte> RequestAccess()
        {
            lock(_dataLock)
            {
                if (this is null) throw new ArgumentNullException("uiHost");

                this.ShowDialog();

                return _changedPermissionState;
            }

            
        }

        private void uiPermissionRequest_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntGrant_Click(object sender, EventArgs e)
        {
            _changedPermissionState = 1;
            this.Close();
        }

        private void bntDeny_Click(object sender, EventArgs e)
        {
            _changedPermissionState = 0;
            this.Close();
        }
    }
}
