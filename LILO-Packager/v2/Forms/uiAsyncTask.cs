using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Gaming.Input.Custom;

namespace LILO_Packager.v2.Forms
{
    public partial class uiAsyncTask : Form
    {
        private static uiAsyncTask _encrypt;
        private static object _lock = new object();
        public static uiAsyncTask Instance()
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new uiAsyncTask();
                }

                return _encrypt;
            }
        }

        private uiAsyncTask()
        {
            InitializeComponent();
        }

        private void uiAsyncTask_Load(object sender, EventArgs e)
        {

        }

        public void UpdateProcess(double progressForBar)
        {
            progressBar.Value = (int)progressForBar;
        }
    }
}
