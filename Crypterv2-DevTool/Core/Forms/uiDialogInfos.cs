using Crypterv2.DevTool.Core.Plugins.Config;
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

            if(!Canceled)
            {
                var exConfigManager = new PluginConfigManager(uiPluginKit.Instance().SelectedPlugin.Name, new Crypterv2.DevTool.Core.Plugins.Types.PluginConfig()
                {
                    Name = uiPluginKit.Instance().SelectedPlugin.Name,
                    Description = uiPluginKit.Instance().SelectedPlugin.Description,
                    Version = uiPluginKit.Instance().SelectedPlugin.Version,
                    State = uiPluginKit.PluginDevState,
                    Changes = uiPluginKit.ChannelLog,
                    PluginIcon = uiPluginKit.Instance().PluginIcon
                });

                exConfigManager.SavePluginConfig();

                uiPluginKit.Instance().pluginUi.PluginName = uiPluginKit.Instance().SelectedPlugin.Name;
                uiPluginKit.Instance().pluginUi.PluginVersion = uiPluginKit.Instance().SelectedPlugin.Version;
            }

            return _plugin;
        }

        private void uiDialogInfos_Load(object sender, EventArgs e)
        {
            txtName.Texts = _plugin.Name;
            txtVersion.Texts = _plugin.Version;
            txtReadMe.Text = uiPluginKit.ChannelLog;
            cmbState.Text = uiPluginKit.PluginDevState;
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            _plugin = _backup;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            uiPluginKit.ChannelLog = txtReadMe.Text;
            uiPluginKit.PluginDevState = cmbState.Text;
            _plugin.Version = txtVersion.Texts;
            _plugin.Name = txtName.Texts;

            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uiPluginKit.PluginFeatures = new uiDialogFeatures(uiPluginKit.PluginFeatures).GetFeatures();
        }
    }
}
