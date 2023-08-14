using LILO_Packager.v2.shared;
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
    public partial class uiArgumentStart_Encrypt : Form
    {

        private static uiArgumentStart_Encrypt _instance_de;
        private static DecryptedFile deFile = null; 
        private string tempFile = Path.Combine(Path.GetTempPath(), new Random().NextInt64(9999, 12345) + "temp_lsf.mp3");
        public Core.History.DatabaseHandling dbHandler = new Core.History.DatabaseHandling();

        public static uiArgumentStart_Encrypt Instance(DecryptedFile defile)
        {
            if (_instance_de == null)
            {
                _instance_de = new uiArgumentStart_Encrypt(defile);
            }

            return _instance_de;
        }

        public uiArgumentStart_Encrypt(DecryptedFile defile)
        {
            InitializeComponent();

            deFile = defile;
        }

        private void uiArgumentStart_Decrypt_Load(object sender, EventArgs e)
        {

        }

        private async void uiArgumentStart_Encrypt_Load(object sender, EventArgs e)
        {
            if (deFile is not null)
            {
                this.lblName.Text = deFile.FileName;
                this.lblSize.Text = deFile.Size;

                await dbHandler.InitializeDatabaseAsync(process =>
                {

                });

                this.lblEncryption.Text = deFile.Encryption;
            }
        }
    }
}
