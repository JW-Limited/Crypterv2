using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;

namespace LILO_Packager.v2.Forms;
public partial class uiFileDrop : Form
{
    public Action<string> OnFileDrop;

    public uiFileDrop(Action<string> file)
    {
        InitializeComponent();

        OnFileDrop = file;
    }

    private void uiFileDrop_Load(object sender, EventArgs e)
    {

    }
}
