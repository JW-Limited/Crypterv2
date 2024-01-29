using LILO_Packager.v2.Core.Dialogs;

namespace LILO_Packager.v2.Forms
{
    public partial class uiFileDropDialog : Form
    {
        public FileDropDialogPreferences preferences;

        public uiFileDropDialog(FileDropDialogPreferences preferences)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
            this.preferences = preferences;
            FileAccepted = preferences.FileAccepted;
            lblTask.Text = preferences.TaskName;
            label1.Text = preferences.TaskDescription;
        }

        public Action<string> FileAccepted { get; set; }

        private void pnlFileDrop_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pnlFileDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            e.Message = "Import to Database";
            e.DropImageType = DropImageType.Move;
        }

        private void pnlFileDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
            {
                this.Close();
                e.Effect = DragDropEffects.All;
                FileAccepted?.Invoke(files[0]);
            }

            this.Close();
        }

        private void uiFileDropDialog_Load(object sender, EventArgs e)
        {

        }

        private void bntShare_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                DefaultExt = ".cdex",
                CheckFileExists = true,
                AddExtension = true,
                Filter = "Cloud Entry|*.cdex",
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                FileAccepted?.Invoke(ofd.FileName);
            }

            this.Close();
        }
    }
}
