namespace LILO_Packager.v2.Plugins.ThirdParty;
public class PluginIconDialog : Form
{
    private PictureBox pictureBox;

    public PluginIconDialog(Bitmap pluginIcon)
    {
        InitializeComponents();
        SetIconImage(pluginIcon);
    }

    private void InitializeComponents()
    {
        this.Text = "Plugin Icon";
        this.Size = new Size(500, 500);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MinimizeBox = false;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.MinimumSize = new Size(200, 200); 

        pictureBox = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.Zoom
        };

        this.Controls.Add(pictureBox);
    }

    private void SetIconImage(Bitmap pluginIcon)
    {
        if (pluginIcon != null)
        {
            pictureBox.Image = pluginIcon;

            if (pluginIcon.Width > 500 || pluginIcon.Height > 500)
            {
                this.ClientSize = new Size(Math.Min(pluginIcon.Width, 500), Math.Min(pluginIcon.Height, 500));
            }
            else
            {
                this.ClientSize = new Size(500, 500);
            }
        }
        else
        {
            pictureBox.Image = null;
            this.ClientSize = new Size(500, 500); 
        }
    }

    public static void ShowPluginIcon(Bitmap pluginIcon)
    {
        using (var dialog = new PluginIconDialog(pluginIcon))
        {
            dialog.ShowDialog();
        }
    }
}
