using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Controls
{
    public partial class DynamikPanelControl : UserControl
    {
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string SubText { get => lblSubTitle.Text; set => lblSubTitle.Text = value; }
        public string MiddleText { get => lblMiddleText.Text; set => lblMiddleText.Text = value; }
        public override Color BackColor { get => pnlBackground.FillColor ; set => pnlBackground.FillColor = value; }
        public bool EnabledState { get => chbControl.EnabledState; set => chbControl.EnabledState = value; }
        public bool Checked { get => chbControl.Checked; set => chbControl.Checked = value; }

        public DynamicToggleButton ToggleButton { get => chbControl; set => chbControl = value; }

        public DynamikPanelControl()
        {
            InitializeComponent();
        }
    }
}
