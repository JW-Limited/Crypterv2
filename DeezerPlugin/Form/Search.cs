using LILO_Packager.Properties;
using LILO_Packager.v2.Core.Authentication;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Core.LILO.Types;
using System;
using System.Windows.Forms;


namespace DeezerPlugin.Forms
{
    public partial class Search : Form
    {
        private static Search _encrypt;
        private static object _lock = new object();
        public static Search Instance()
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new Search();
                }

                return _encrypt;
            }
        }


        private Search()
        {
            InitializeComponent();
        }

        private void PluginInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
