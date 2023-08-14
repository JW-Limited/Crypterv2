using Crypterv2_DevTool.Core;

namespace Crypterv2_DevTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var feat = new FeatureFlag();
                feat.ToggleFeatureViaSocket("NewEncryptionCore", true);
            }
            catch 
            {
                MessageBox.Show("Cant connect to Crypterv2.","DevConnection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
