using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms;
public partial class uiSettings : Form
{
    private static uiSettings _encrypt;
    public shared.FileOperations sharedFile = new();
    private static object _lock = new object();
    public static uiSettings Instance()
    {
        lock (_lock)
        {
            if (_encrypt is null)
            {
                _encrypt = new uiSettings();
            }

            return _encrypt;
        }
    }


    private uiSettings()
    {
        InitializeComponent();

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = true;
            this.Hide();
        };
    }

    private void uiSettings_Load(object sender, EventArgs e)
    {

    }
}
