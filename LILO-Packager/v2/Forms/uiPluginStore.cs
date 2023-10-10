using LILO_Packager.v2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPluginStore : Form, ILILOPluginStore
    {
        private static uiPluginStore _instance;

        public static uiPluginStore Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new uiPluginStore();
                }

                return _instance;

            }
        }

        public uiPluginStore()
        {
            InitializeComponent();

            this.FormClosing += (s, e) =>
            {
                e.Cancel = true;
                this.Hide();
            };

            //Program.InstanceCacheContainer.Register<ILILOPluginStore>(() => _instance.Value);
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            Program.InstanceCacheContainer.Resolve<ILILOMainHost>().OpenInApp(uiPluginManager.Instance(null, null));
        }

        private void uiPluginStore_Load(object sender, EventArgs e)
        {

        }
    }

    public interface ILILOPluginStore
    {
        
    }
}
