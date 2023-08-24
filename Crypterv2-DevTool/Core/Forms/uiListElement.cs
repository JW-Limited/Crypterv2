using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypterv2_DevTool.Core;

namespace Crypterv2_DevTool.Core.Forms
{
    public partial class uiListElement : Form
    {
        private TcpClient tcpClient;

        private FlagInfo _info;

        public uiListElement(FlagInfo info, TcpClient client)
        {
            InitializeComponent();
            tcpClient = client;
            _info = info;

            this.FormClosing += (s, e) =>
            {
                MainHost.GetInstance().Main_Load(s,e);
            };
        }

        private void uiListElement_Load(object sender, EventArgs e)
        {
            this.lblFeature.Text = _info.Name;
            this.lblFeatureState.Text = _info.EnabledState.ToString();
            this.lblDescription.Text = _info.Description;

            if (_info.EnabledState)
            {
                bntChange.Text = "Disable";
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

        private void bntChange_Click(object sender, EventArgs e)
        {
            tcpClient.Close();

            var handler = new FeatureFlag();
            handler.ToggleFeatureViaSocket(featureName: _info.Name);
            this.Close();
        }
    }
}
