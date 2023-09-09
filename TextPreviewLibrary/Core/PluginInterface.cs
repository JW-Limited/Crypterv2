using LILO_Packager.v2.plugins.PluginCore;
using System.Drawing;
using System.Windows.Forms;
using TextPreviewLibrary.Core.Formats;

namespace TextPreviewLibrary.Core;
public partial class PluginInterface : Form
{
    public string Version;
    public PluginID id;
    public string Name;
    public PluginID Id => throw new NotImplementedException();
    public CrypterTextFile _file;
    public string openedFilePath;
    private static object _lock = new object();
    private static PluginInterface _encrypt;

    public static PluginInterface Instance(string Version, PluginID id, string Name, bool needNewInstance)
    {
        lock (_lock)
        {
            if (_encrypt is null || _encrypt.IsDisposed || needNewInstance)
            {
                _encrypt = new PluginInterface(Version, id, Name);
            }

            return _encrypt;
        }
    }

    public static void SetInstance(object newInstance)
    {
        _encrypt = (PluginInterface)newInstance;
    }

    public CrypterTextFile _emptyFile = new CrypterTextFile() 
    {
        CreatedAt = DateTime.Now,
        Author = "",
        IsLocked = false,
        FileName = "",
        RtfContent = "",
        TextColor = Color.Black,
        LastModified = DateTime.Now,
    };


    public PluginInterface(string Version, PluginID id, string Name)
    {
        InitializeComponent();

        this.id = id;
        this.Version = Version;
        this.Name = Name;

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = true;
            this.Hide();
        };
    }

    public void SetContent(CrypterTextFile file)
    {
        if (file is not null)
        {
            _file = file;
        }
    }

    public void ui_Load(object sender, EventArgs e)
    {
        lblVersion.Text = Version;

        foreach(Control c in this.Controls)
        {
            try
            {
                if(PluginBase._thManager is not null)
                    PluginBase._thManager.RegisterControl(c, LILO_Packager.v2.Core.ColorManager.ThemeManager.ModeType.Light, Color.White, Color.Black);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        if (_file is not null)
        {
            mainTextBox.Text = _file.RtfContent;
            mainTextBox.Enabled = !_file.IsLocked;
            if(_file.IsLocked)
            {
                lblTip.Text = "You need to safe the file first before you can edit it.";
            }
            mainTextBox.ForeColor = _file.TextColor;
            lblWordCounts.Text = "Words: " + _file.WordCount;
            lblLanguage.Text = _file.FileName;
        }
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
    }

    private void bntPlugin_Click(object sender, EventArgs e)
    {
        pnlMenu.Visible = !pnlMenu.Visible;
        bntMenu.Checked = !bntMenu.Checked;

        if (bntDesign.Checked)
        {
            bntOpenDesingPop_Click(sender, e);
        }
    }

    private void guna2Button1_Click_1(object sender, EventArgs e)
    {
        if (openedFilePath is not null or "")
        {
            if (File.Exists(openedFilePath))
            {
                var file = _file;
                file.RtfContent = mainTextBox.Text;
                file.LastModified = DateTime.Now;
                file.TextColor = mainTextBox.ForeColor;
                file.version = PluginBase._sVersion;


                CrypterTextFile.SaveInstanceToFile(file, openedFilePath);

                mainTextBox.Text = file.RtfContent;
                mainTextBox.Enabled = !file.IsLocked;
                mainTextBox.ForeColor = file.TextColor;
                lblWordCounts.Text = "Words: " + file.WordCount;
                lblLanguage.Text = file.FileName;
            }
        }
        else
        {
            lblTip.Text = "";

            var ofd = new SaveFileDialog()
            {
                Filter = "CrypterTextFile|*.ctv|Alle Datein(.)|*.",
                InitialDirectory = Application.StartupPath,
                ShowHiddenFiles = true,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                var file = new CrypterTextFile()
                {
                    Author = Environment.UserDomainName,
                    FileName = new FileInfo(ofd.FileName).Name,
                    IsLocked = false,
                    TextColor = mainTextBox.ForeColor,
                    RtfContent = mainTextBox.Text,
                    CreatedAt = DateTime.Now,
                    LastModified = DateTime.Now,
                    version = PluginBase._sVersion
                };

                CrypterTextFile.SaveInstanceToFile(file, ofd.FileName);
                _file = file;
                openedFilePath = ofd.FileName;

                mainTextBox.Text = file.RtfContent;
                mainTextBox.Enabled = !file.IsLocked;
                mainTextBox.ForeColor = file.TextColor;
                lblWordCounts.Text = "Words: " + file.WordCount;
                lblLanguage.Text = file.FileName;
            }

        }

        bntPlugin_Click(sender, e);

    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        try
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "CrypterTextFile|*.ctv|Alle Datein(.)|*.",
                AddToRecent = true,
                ShowPinnedPlaces = true,
                ShowHiddenFiles = true,
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var file = CrypterTextFile.LoadInstanceFromFile(ofd.FileName);

                mainTextBox.Text = file.RtfContent;
                mainTextBox.Enabled = !file.IsLocked;
                mainTextBox.ForeColor = file.TextColor;
                lblWordCounts.Text = "Words: " + file.WordCount;
                lblLanguage.Text = file.FileName;
                lblVersion.Text += " - " + file.version;

                _file = file;
                openedFilePath = ofd.FileName;
            }

            bntPlugin_Click(sender, e);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MessageBox.Show("It seems that the file was created with another structure i can not understand. Please be sure you use the same version that the file was created with.\n\n" + ex.Message,"Not Matching Formats",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show("It seems that the file is missing on of its main components. Please be sure you use the same version that the file was created with and it is not corrupted.\n\n" + ex.Message, "Not Matching Formats", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void newFile_Click(object sender, EventArgs e)
    {
        _file = null;
        openedFilePath = null;
        mainTextBox.Text = _emptyFile.RtfContent;
        mainTextBox.Enabled = !_emptyFile.IsLocked;
        mainTextBox.ForeColor = _emptyFile.TextColor;
        lblWordCounts.Text = "Words: " + _emptyFile.WordCount;
        lblLanguage.Text = _emptyFile.FileName;

        bntPlugin_Click(sender, e);
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void PluginInterface_Shown(object sender, EventArgs e)
    {
        ui_Load(sender, e);
    }

    private void bntOpenDesingPop_Click(object sender, EventArgs e)
    {
        bntDesign.Checked = !bntDesign.Checked;
        if(bntMenu.Checked)
        {
            bntPlugin_Click(sender, e);
        }
        pnlDesing.Visible = !pnlDesing.Visible;
    }
}
