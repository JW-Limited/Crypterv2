using Bunifu.UI.WinForms.Helpers.Transitions;
using LILO_Packager.v2.plugins.PluginCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextPreviewLibrary.Core.Formats;

namespace TextPreviewLibrary.Core;
public partial class PluginInterface : Form
{
    public string Version;
    public PluginID id;
    public string Name;
    public PluginID Id => throw new NotImplementedException();

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
        _encrypt = (PluginInterface) newInstance;
    }

    public CrypterTextFile _file;
    public string openedFilePath;

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

        if (_file is not null)
        {
            mainTextBox.Text = _file.RtfContent;
            mainTextBox.Enabled = !_file.IsLocked;
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
            var ofd = new SaveFileDialog()
            {
                Filter = "CrypterTextFile(.ctv)|*.ctv|Alle Datein(.)|*.",
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
                    LastModified = DateTime.Now
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
        var ofd = new OpenFileDialog()
        {
            Filter = "CrypterTextFile(.ctv)|*.ctv|Alle Datein(.)|*.",
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

            _file = file;
            openedFilePath = ofd.FileName;
        }

        bntPlugin_Click(sender, e);

    }

    private void newFile_Click(object sender, EventArgs e)
    {

    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void PluginInterface_Shown(object sender, EventArgs e)
    {
        ui_Load(sender,e);
    }
}
