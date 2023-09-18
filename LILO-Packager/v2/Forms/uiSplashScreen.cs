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
    public partial class uiSplashScreen : Form
    {
        private static readonly Lazy<uiSplashScreen> lazyInstance = new Lazy<uiSplashScreen>(() => new uiSplashScreen());
        public static uiSplashScreen Instance => lazyInstance.Value;

        private uiSplashScreen()
        {
            InitializeComponent();
        }

        private void uiSplashScreen_Load(object sender, EventArgs e)
        {
            lblAddtional.Text = Program.Version.ToString();
        }
    }
}
