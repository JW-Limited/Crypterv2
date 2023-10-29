using Crypterv2_DevTool.Core.Forms;
using LILO_Packager.v2.Plugins.Model;

namespace Crypterv2.DevTool.Core.Forms
{
    public partial class uiDialogInfos : Form
    {
        public PluginEntry _plugin { get; set; }
        public PluginEntry _backup { get; set; }
        public bool Canceled { get; set; }

        public uiDialogInfos(PluginEntry plugin)
        {
            InitializeComponent();

            this._backup = plugin;
            this._plugin = plugin;
        }

        public PluginEntry GetInfos()
        {
            base.StartPosition = FormStartPosition.CenterParent;
            base.ShowDialog();

            return _plugin;
        }

        private void uiDialogInfos_Load(object sender, EventArgs e)
        {
            txtName.Texts = _plugin.Name;
            txtVersion.Texts = _plugin.Version;
            txtReadMe.Text = uiTestPlugin.ChannelLog;
            cmbState.Text = uiTestPlugin.PluginDevState;
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            _plugin = _backup;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            uiTestPlugin.ChannelLog = txtReadMe.Text;
            uiTestPlugin.PluginDevState = cmbState.Text;
            _plugin.Version = txtVersion.Texts;
            _plugin.Name = txtName.Texts;

            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uiTestPlugin.PluginFeatures = new uiDialogFeatures(uiTestPlugin.PluginFeatures).GetFeatures();
        }
    }
}
