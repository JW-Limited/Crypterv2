﻿using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Plugins.PluginCore;
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
    public partial class DynamikPluginListItem : UserControl
    {
        public DynamikPluginListItem()
        {
            InitializeComponent();
        }

        public string PluginName
        {
            get => lblPluginName.Text;
            set => lblPluginName.Text = value;
        }

        public string PluginVersion
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public IPluginBase Plugin { get; set; }

        private void DynamikPluginListItem_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uiPluginManagerv2.Instance.SetPlugin(Plugin);
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
