using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Forms;
public partial class uiLILOAccountLogin : Form
{
    private bool pswVisible = false;
    public static string? errorMessage;
    private ILILOLicenseManager liloManager;
    public static bool loggingInProgress = true;
    private static uiLILOAccountLogin? _instance;

    private uiLILOAccountLogin()
    {
        InitializeComponent();
    }

    public static uiLILOAccountLogin Instance()
    {
        if (_instance == null)
        {
            _instance = new uiLILOAccountLogin();
        }
        return _instance;
    }

    public static void SetInstance(uiLILOAccountLogin instance)
    {
        _instance = instance;
    }


    private void SimplifiedLogin_Load(object sender, EventArgs e)
    {

    }

    private void SimplifiedLogin_FormClosing(object sender, FormClosingEventArgs e)
    {

    }


    private void bntLogin_Click(object sender, EventArgs e)
    {
        pnlLoginLoad.Visible = true;

        Task.Run(async () =>
        {
            ConsoleManager.Instance().WriteLineWithColor("WebClient: Started Authorization", ConsoleColor.Blue);

            liloManager = new LILO_Packager.v2.Core.LILO.LicenseManager();
            var userAuth = await liloManager.LogInAsync(txtUsr.Texts, txtPsw.Texts);

            if (userAuth)
            {
                ConsoleManager.Instance().WriteLineWithColor("WebClient: Fetching User Data...", ConsoleColor.Blue);
                Thread.Sleep(2000);

                ConsoleManager.Instance().WriteLineWithColor("WebClient: All done.", ConsoleColor.Blue);

                this.Close();
            }

            else
            {

                MessageBox.Show("False username or password provided. Please try again.");

                pnlLoginLoad.Visible = false;
            }

        });


    }

    private void pswVisible_Click(object sender, EventArgs e)
    {
        switch (pswVisible)
        {
            case true:
                txtPsw.PasswordChar = true;
                pswVisible = false;
                break;
            case false:
                txtPsw.PasswordChar = false;
                pswVisible = true;
                break;
        }
    }

    private void guna2Panel1_Paint(object sender, PaintEventArgs e)
    {

    }
}
