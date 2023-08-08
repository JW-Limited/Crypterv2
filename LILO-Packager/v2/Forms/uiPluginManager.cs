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
                e.Cancel = true;
                this.Hide();
            };
        }

        private void uiPluginManager_Load(object sender, EventArgs e)
        {
            foreach (PluginEntry entry in plugins)
            {
                //listView1.Items.Add(entry.Name);
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
