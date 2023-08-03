using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager;
public partial class ListBox : Form
{
    public ListBox()
    {
        InitializeComponent();
    }
    private void ListBox_Load(object sender, EventArgs e)
    {
        PrintValues(mainUI.arlist); 
    }

    private void PrintValues(IEnumerable myList)
    {
        foreach (var obj in myList)
        {
            listView1.Items.Add(obj.ToString());
            listView1.Show();
            listView1.Refresh();
        }
    }
}
