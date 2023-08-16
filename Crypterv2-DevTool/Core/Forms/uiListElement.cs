using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypterv2_DevTool.Core.Forms
{
    public partial class uiListElement : Form
    {

        private FlagInfo _info;

        public uiListElement(FlagInfo info)
        {
            InitializeComponent();

            _info = info;
        }

        private void uiListElement_Load(object sender, EventArgs e)
        {
            this.lblFeature.Text = _info.Name;
            this.lblFeatureState.Text = _info.EnabledState.ToString();
            this.lblDescription.Text = _info.Description;

            if (_info.EnabledState)
            {
                bntChange.Text = "Disabled";
            }
            else
            {
                bntChange.Text = "Enable";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
