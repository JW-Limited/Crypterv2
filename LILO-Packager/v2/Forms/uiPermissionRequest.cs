using LILO_Packager.v2.Plugins.Internal;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPermissionRequest : Form
    {
        private readonly PluginData.PermissionSet _permission;
        private readonly PluginData _data;
        private object _dataLock = new object();
        private byte _changedPermissionState = 0;

        public uiPermissionRequest(PluginData.PermissionSet permission, PluginData data)
        {
            InitializeComponent();

            if (permission.Equals(null) || permission is null || data is null) throw new ArgumentNullException(nameof(permission));
            if (permission.Enabled) throw new AccessAlreadyGrantedException();

            _permission = permission;
            _data = data;
        }

        public async Task<byte> RequestAccess()
        {
            if (this is null) throw new ArgumentNullException("uiHost");

            this.ShowDialog();

            return _changedPermissionState;
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
    }
}
