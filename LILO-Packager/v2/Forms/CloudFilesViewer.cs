using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Contracts;

namespace LILO_Packager.v2.Forms
{
    public partial class CloudFilesViewer : Form
    {
        private ICloudServiceManager CloudServiceManager { get; set; }
        private FileIndexStorage MatrixHandler { get; set; }


        public CloudFilesViewer(ICloudServiceManager manager)
        {
            InitializeComponent();

            CloudServiceManager = manager;
            MatrixHandler = new FileIndexStorage();
        }

        private void CloudFilesViewer_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Program.CloudVersion;
            Task.Run(() =>
            {
                if (CloudSyncroniztationBase.HasNetworkConnection())
                {
                    lblNetwork.Text = "Connected";
                    lblNetwork.ForeColor = Color.Green;

                    if (CloudSyncroniztationBase.CloudAvailable())
                    {
                        lblCloud.Text = "Connected";
                        lblCloud.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblCloud.Text = "Offline";
                        lblCloud.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblNetwork.Text = "Offline";
                    lblNetwork.ForeColor = Color.Red;
                    lblCloud.Text = "Offline";
                    lblCloud.ForeColor = Color.Red;
                }

                lblMatrix.Text = MatrixHandler.GetMatrixFile().MatrixDetail.MatrixVerifier.Name;
                lblMatrixVersion.Text = MatrixHandler.GetMatrixFile().MatrixDetail.SchemeVersion;
            });
        }
    }
}
