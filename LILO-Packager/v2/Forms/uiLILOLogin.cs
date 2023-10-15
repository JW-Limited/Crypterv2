using LILO_Packager.v2.Core.LILO;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Core.LILO.Types;
using LILO_Packager.v2.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinForms.Documents.Lists;

namespace LILO_Packager.v2.Forms
{
    public partial class uiLILOLogin : Form
    {
        private bool pswVisible = false;
        public static string? errorMessage;
        private ILILOLicenseManager liloManager;
        public static bool loggingInProgress = true;
        private static uiLILOAccountLogin? _instance;

        public uiLILOLogin()
        {
            InitializeComponent();
        }

        private void uiLILOLogin_Load(object sender, EventArgs e)
        {
            lblVerison.Text = Program.Version;
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

        private void bntLogin_Click(object sender, EventArgs e)
        {
            pnlLoginLoad.Visible = true;

            Task.Run(async () =>
            {
                ConsoleManager.Instance().WriteLineWithColor("WebClient: Started Authorization", ConsoleColor.Blue);
                liloManager = new Core.LILO.LicenseManager();
                var userAuth = await liloManager.LogInAsync(txtUsr.Texts, txtPsw.Texts);

                if (userAuth)
                {
                    ConsoleManager.Instance().WriteLineWithColor("WebClient: Fetching User Data...", ConsoleColor.Blue);
                    Thread.Sleep(2000);

                    ConsoleManager.Instance().WriteLineWithColor("WebClient: All done.", ConsoleColor.Blue);
                    this.Invoke(new Action(() =>
                    {
                        pnlSucces.Visible = true;
                    }));
                }

                else
                {
                    this.Invoke(new Action(() =>
                    {
                        pnlLoginLoad.Visible = false;
                        MessageBox.Show("False username or password provided. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }

            });
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature isnt availlabel right now. The Application is only for testers.", "Only for Testers", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bntGo(object sender, EventArgs e)
        {
            MainHost.Instance().loggedInUser = UserManager.Instance().LoadUserFromFile(MainHost.Instance().UserFile);
            MainHost.Instance()._userAdvanced = new UserAdvanced(MainHost.Instance().loggedInUser);

            MainHost.Instance().OpenInApp(Forms.uiWebView.Instance(new Uri("http://localhost:" + MainHost.Instance().Port)));
            MainHost.Instance().hider.Visible = true;
        }
    }
}
