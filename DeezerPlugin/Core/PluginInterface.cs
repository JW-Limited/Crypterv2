using LILO_Packager.Properties;
using LILO_Packager.v2.Core.Authentication;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Core.LILO.Types;
using System;
using System.Windows.Forms;


namespace DeezerPlugin.Core
{
    public partial class PluginInterface : Form
    {
        private static PluginInterface _encrypt;
        private static object _lock = new object();
        public static PluginInterface Instance()
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new PluginInterface();
                }

                return _encrypt;
            }
        }


        private PluginInterface()
        {
            InitializeComponent();
        }

        private void PluginInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
