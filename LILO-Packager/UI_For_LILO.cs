using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LILO;
using LILO_Packager.Properties;
using Param.IO.Compression;

namespace LILO_Packager;
public partial class InstallPackage : Form
{
    public static string? filepath;
    public static bool OperationSuccess = false;
    public static string productName;
    public static Image? productImg;
    public static bool installError;
    
    public InstallPackage()
    {
        InitializeComponent();
    }

    private void ShowError(Label lbl, string error)
    {
        lbl.Text = error;
        lbl.ForeColor = Color.Red;
    }

    public async void getPackage()
    {
        foreach (var file in Directory.GetFiles(".\\temp"))
        {
            if (file == "key.key") return;
            File.Delete(file);

        }

        WebClient client = new WebClient();
        var User_PSW = client.DownloadData("https://pastebin.com/raw/EmRwJPSE");

        try
        {
            var key = Encoding.ASCII.GetString(User_PSW);

            mainUI.LicenseFile = filepath;
            mainUI.decrypt(key);

            filepath = ".\\temp\\tool.rar";

            if (File.Exists(filepath))
            {
                Directory.CreateDirectory("\\tools\\runtime");

                progressBar.Visible = true;

                var progress = new Progress<int>(value =>
                {
                    progressBar.Value = value;
                });

                await UnpackArchiveAsync(progress);


                foreach (var file in Directory.GetFiles(".\\temp"))
                {
                    if (file == "key.key") { }
                    else
                    {
                        lblProductName.Text = file;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            LILO.DialogHost dialogHost = new LILO.DialogHost();
            dialogHost.Name = "Error";
            dialogHost.Title = "Fehler";
            dialogHost.SecondButton = "Ok";
            dialogHost.Clor1 = Color.MidnightBlue;
            dialogHost.Content = ex.Message;
            dialogHost.MessageIcon = Resources.unavailable_240px;
            dialogHost.ExecutionCommand = "errorHandling";
            dialogHost.ShowDialog();
            installError = true;
        }


    }

    public async Task UnpackArchiveAsync(IProgress<int> progress)
    {
        try
        {
            string winrarPath = @"C:\Program Files\WinRAR\WinRAR.exe";
            string archivePath = @".\temp\tool.rar";
            string outputDirectory = @".\temp";

            ProcessStartInfo startInfo = new ProcessStartInfo(winrarPath);
            startInfo.Arguments = $"e \"{archivePath}\" \"{outputDirectory}\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.OutputDataReceived += (sender, e) =>
                {
                    if (int.TryParse(e.Data, out int progressValue))
                    {
                        progress.Report(progressValue);
                    }
                };

                process.Start();
                process.BeginOutputReadLine();

                await process.WaitForExitAsync();
            }
        }
        catch (Exception ex)
        {
            // Exception handling code remains the same
        }
    }


    //https://pastebin.com/raw/EmRwJPSE

    private void UI_For_LILO_Load(object sender, EventArgs e)
    {
        getPackage();

        if (filepath == null)
        {
            this.BackgroundImage = Resources.errorScreen;
            this.Text = "Error - Package not Valid";
            tgl_Connect.Enabled = false;
            tgl_delPkg.Enabled = false;
            tgl_diagnostics.Enabled = false;
            bnt_Install.Enabled = false;
            txtKey.Enabled = false;
            return;
        }
    }

    private void sButton1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Install(object sender, EventArgs e)
    {
        if (txtKey.Texts == "")
        {
            ShowError(lblLicenseKey, "Insert KEY");
            return;
        }

        tgl_Connect.Enabled = false;
        tgl_delPkg.Enabled = false;
        tgl_diagnostics.Enabled = false;
        bntCancel.Enabled = false;
        bnt_Install.Enabled = false;
        txtKey.Enabled = false;

        progressBar.Visible = true;
        progressBar.Value = 10;


    }

    private void lblProductInfo_Click(object sender, EventArgs e)
    {

    }
}
