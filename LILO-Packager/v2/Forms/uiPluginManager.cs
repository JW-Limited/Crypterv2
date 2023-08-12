using LILO_Packager.v2.plugins.Model;
using LILO_Packager.v2.plugins.PluginCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPluginManager : Form
    {
        private static uiPluginManager _encrypt;
        private static object _lock = new object();
        public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();
        private PluginManager manager = null;

        public static uiPluginManager Instance(ObservableCollection<PluginEntry> pluginEntries, PluginManager plgMng)
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


        private uiPluginManager(ObservableCollection<PluginEntry> pluginEntries, PluginManager plgMng)
        {
            InitializeComponent();

            this.plugins = pluginEntries;
            this.manager = plgMng;

            this.FormClosing += (sender, e) =>
            {
                _encrypt = null;
            };
        }

        private void uiPluginManager_Load(object sender, EventArgs e)
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
                listViewBerechtigungen.Items.Add("n/a");
            }
        }

        private void pluginEntryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
