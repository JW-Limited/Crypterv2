using Crypterv2.DevTool.Core.Plugins.Config;
using Crypterv2_DevTool.Core.Forms;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace Crypterv2.DevTool.Core.Forms
{
    public partial class uiDialogInfos : Form
    {
        public IPluginBase _plugin { get; set; }
        public IPluginBase _backup { get; set; }
        public bool Canceled { get; set; }

        public uiDialogInfos(IPluginBase plugin)
        {
            InitializeComponent();

            this._backup = plugin;
            this._plugin = plugin;
        }

        public IPluginBase GetInfos()
        {
            base.StartPosition = FormStartPosition.CenterParent;
            base.ShowDialog();



            if(!Canceled)
            {
                var exConfigManager = new PluginConfigManager(_plugin.Name, new Crypterv2.DevTool.Core.Plugins.Types.PluginConfig()
                {
                    Name = _plugin.Name,
                    Description = _plugin.Description,
                    Version = _plugin.Version,
                    State = uiPluginKit.PluginDevState,
                    Changes = uiPluginKit.ChannelLog,
                    PluginIcon = uiPluginKit.Instance().PluginIcon
                });

                exConfigManager.SavePluginConfig();

                uiPluginKit.Instance().pluginUi.PluginName = ((IPluginBase)uiPluginKit.Instance().SelectedPlugin).Name;
                uiPluginKit.Instance().pluginUi.PluginVersion = ((IPluginBase)uiPluginKit.Instance().SelectedPlugin).Version;
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
