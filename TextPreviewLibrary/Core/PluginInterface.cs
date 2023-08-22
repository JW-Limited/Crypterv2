using LILO_Packager.v2.plugins.PluginCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public static PluginInterface Instance(string Version, PluginID id, string Name)
    {
        lock (_lock)
        {
            if (_encrypt is null || _encrypt.IsDisposed)
            {
                _encrypt = new PluginInterface(Version, id, Name);
            }

            return _encrypt;
        }
    }


    private PluginInterface(string Version, PluginID id, string Name)
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

    private void ui_Load(object sender, EventArgs e)
    {
        lblVersion.Text = Version;
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
        var myclass = new CrypterTextFile()
        {
            Author = "Joe",
            FileName = "Test",
            Locked = false,
            TextColor = Color.Black,
            Text = mainTextBox.Text
        };

        CrypterTextFile.SetInstanceToFile(myclass, ".\\test.ctv");
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        var ofd = new OpenFileDialog()
        {
            AddToRecent = true,
            ShowPinnedPlaces = true,
            ShowHiddenFiles = true,
            Multiselect = false
        };

        if(ofd.ShowDialog() == DialogResult.OK)
        {
            var file = CrypterTextFile.GetInstanceFromFile(ofd.FileName);

            mainTextBox.Text = file.Text;
            mainTextBox.Enabled = !file.Locked;
            mainTextBox.ForeColor = file.TextColor;
        }
    }
}
