using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO;
public partial class DialogHost : Form
{

    //#####################################################
    //#####################################################
    //##
    //##
    //##     #####################################
    //##     #                                   #
    //##     # Dynamic Message Dialog by Jw Lmt. #
    //##     #                                   #
    //##     #####################################
    //##
    //##
    //####################################################
    //####################################################


    string secondButton = "n/A";
    Color clor1 = Color.MidnightBlue;
    string title = "n/A";
    string content = "n/A";
    Image img = null;
    string com = null;

    public DialogHost()
    {
        InitializeComponent();
    }

    public string Title
    {
        get => title;
        set => title = value;
    }
    public Color Clor1
    {
        get => clor1;
        set => clor1 = value;
    }
    public string SecondButton
    {
        get => secondButton;
        set => secondButton = value;
    }
    public string Content
    {
        get => content;
        set => content = value;
    }
    public Image MessageIcon
    {
        get => img;
        set => img = value;
    }
    public string ExecutionCommand
    {
        get => com;
        set => com = value;
    }

    private void DialogHost_Load(object sender, EventArgs e)
    {
        bntSecond.Text = SecondButton;
        lblContent.Text = Content;
        lblDialogTitle.Text = Title;
        bntSecond.FillColor = clor1;
        MessageIconShower.BackgroundImage = img;
        operationMode();
    }

    private void operationMode(int mode = 1)
    {
        /* Modes
         * 0 = Nothing
         * 1 = Desicion Maker (Important)
         * 2 = Close Up (Very Important)
         * 3 = Information (Medium)
         */
        
        switch(mode)
        {
            case 0:
                this.Close();
                //AutoLoger.Main(0, "Null Exception", "LILO.Controller.DialogHost");
                return;
            case 1:
                this.TopMost = true;
                this.TopLevel = true;
                this.Activate();
                this.LogicalToDeviceUnits(DeviceDpi);
                System.Media.SystemSounds.Asterisk.Play();
                return;

        }
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        Actions(com);
        this.Close();
    }

    private void bntCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }


    private void Actions(string command)
    {
        switch (command)
        {
            case "errorHandling":
                //AutoLoger.Main(1, content, "DialogHost");
                break;
        }
    }

    private void pnl_proc_Paint(object sender, PaintEventArgs e)
    {

    }
}
