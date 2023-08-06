using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionLibary.Core;
public partial class PluginInterface : Form
{
    private static PluginInterface _encrypt;
    private static object _lock = new object();
    public static PluginInterface Instance()
    {
        lock (_lock)
        {
            if (_encrypt is null)
            {
                _encrypt = new PluginInterface();
            }

            return _encrypt;
        }
    }


    private PluginInterface()
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
