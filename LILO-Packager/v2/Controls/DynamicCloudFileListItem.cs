using LILO_Packager.v2.Cloud.Storage;
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
    public partial class DynamicCloudFileListItem : UserControl
    {
        public DynamicCloudFileListItem()
        {
            InitializeComponent();
        }

        public string FileName 
        {
            get => lblFileName.Text; 
            set => lblFileName.Text = value; 
        }

        public string FileDetails
        {
            get => lblDetails.Text;
            set => lblDetails.Text = value;
        }

        public string FileSize
        {
            get => lblFileSize.Text;
            set => lblFileSize.Text = value;
        }
    }
}
