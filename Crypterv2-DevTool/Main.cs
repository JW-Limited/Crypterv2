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
                this.button1.Text = "Connected";
                this.button1.Enabled = false;

                listViewHistory.Items.Clear();

                var features = feat.ListFeaturesViaSocket();

                foreach (var kv in features)
                {
                    var item = new ListViewItem()
                    {
                        Text = $"{kv.Key}",
                    };

                    item.SubItems.Add(kv.Value.ToString());
                    listViewHistory.Items.Add(item);
                }
            }
            catch 
            {
                this.button1.Text = "Error";
                MessageBox.Show("Cant connect to Crypterv2.","DevConnection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
