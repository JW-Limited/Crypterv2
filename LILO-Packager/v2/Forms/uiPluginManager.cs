using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Collections.ObjectModel;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPluginManager : Form
    {
        private static uiPluginManager _encrypt;
        private static object _lock = new object();
        public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();
        private PluginManagerv2 manager = null;

        public static uiPluginManager Instance(ObservableCollection<PluginEntry> pluginEntries, PluginManagerv2 plgMng)
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new uiPluginManager(pluginEntries, plgMng);
                }

                return _encrypt;
            }
        }


        private uiPluginManager(ObservableCollection<PluginEntry> pluginEntries, PluginManagerv2 plgMng)
        {
            InitializeComponent();

            this.plugins = pluginEntries;
            this.manager = plgMng;

            this.FormClosing += (sender, e) =>
            {
                e.Cancel = true;
                this.Hide();
            };
        }

        private void uiPluginManager_Load(object sender, EventArgs e)
        {
            if(manager != null)
            {
                PluginEntry encryptionLibrary = null;

                foreach (var plugin in plugins)
                {
                    if (PluginID.IDtoString(plugin.ID) == PluginID.IDtoString(PluginID.GetID("enc", "lbl", "lvl01")))
                    {
                        encryptionLibrary = plugin;
                    }
                }
                if (encryptionLibrary is not null)
                {
                    lblSize.Text = encryptionLibrary.Description;
                    lblName.Text = encryptionLibrary.Name;
                    lblVersion.Text = encryptionLibrary.Version;
                    lblAuther.Text = PluginID.IDtoString(encryptionLibrary.ID);
                    listViewUpdates.Items.Add("Latest: " + encryptionLibrary.Version);

                    var listBerechtigungen = new ListViewItem[]
                    {
                    new ListViewItem()
                    {
                        Text = "  +- Managing Account - Licenses."
                    },
                    new ListViewItem()
                    {
                        Text = "  +- Create Directorys."
                    },
                    new ListViewItem()
                    {
                        Text = "  +- Gain Access to youre Account-Details (Email,Name,Subscriptionstatus)."
                    },
                    new ListViewItem()
                    {
                        Text = "  +- Gain Access to the Core of the App."
                    },
                    new ListViewItem()
                    {
                        Text = "  +- Request Updates."
                    },
                    };

                    listViewBerechtigungen.Items.AddRange(listBerechtigungen);
                }
            }
        }

        private void pluginEntryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            var login = uiLILOAccountLogin.Instance();
            login.ShowDialog();
        }

        private void bntShop_Clikc(object sender, EventArgs e)
        {
            Program.InstanceCacheContainer.Resolve<ILILOMainHost>().OpenInApp(uiPluginStore.Instance);
        }

        private void bntDeinstall_CLICK(object sender, EventArgs e)
        {

        }
    }
}
