using System.Diagnostics;
using System.Text;
using LILO_Packager.v2.Plugins.ThirdParty.Core;
using LILO_Packager.v2.Plugins.ThirdParty.Forms;
using LILO_Packager.v2.Plugins.ThirdParty.Interfaces;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using static LILO_Packager.v2.MainHost;


namespace LILO_Packager.v2.Plugins.ThirdParty;
public partial class PluginInstaller : Form
{
    private readonly IPlugin _Plugin;
    public bool isInstallMode = false;
    private static PluginInstaller? _instance;
    private StringBuilder sb;
    public static PluginInstaller Instance(IPlugin plugin)
    {
        if (_instance is null || _instance.IsDisposed)
        {
            _instance = new PluginInstaller(plugin);
        }

        return _instance;
    }

    private PluginInstaller(IPlugin plugin)
    {
        InitializeComponent();

        _Plugin = plugin;

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = isInstallMode;
        };
    }

    private void InstallMode(bool value)
    {
        lblFunctionList.Visible = !value;
        lblFunctions.Visible = !value;
        bntInstall.Visible = !value;
        pnlProgess.Visible = value;
        this.ControlBox = !value;
        isInstallMode = value;
    }

    private void UI_For_LILO_Load(object sender, EventArgs e)
    {
        Task.Run(() =>
        {
            sb = new StringBuilder();
            lblProductName.Text = _Plugin.PluginInformation.Name;
            lblProductInfo.Text = _Plugin.PluginInformation.Description;
            lblVersion.Text = _Plugin.PluginInformation.Version.Number + " - " + _Plugin.PluginInformation.Version.State;
            pnlPluginIcon.BackgroundImage = _Plugin.PluginIcon;
            lblFunctionList.Text = string.Empty;
            Console.WriteLine($"Plugin: {_Plugin.PluginInformation.Name}({_Plugin.PluginInformation.Version.Number}{_Plugin.PluginInformation.Version.State})\n\n");
            Console.WriteLine("Features:");
            foreach (var cap in _Plugin.PluginInformation.Capabilities)
            {
                lblFunctionList.Text += ("• " + cap.Name + "\n"); // + " - " + cap.Description
                sb.AppendLine("• " + cap.Name + " - " + cap.Description + "\n");
                Console.WriteLine("+- " + cap.Name + " - " + cap.Description);
            }

            Console.WriteLine("Dependencies:");
            foreach (var dep in _Plugin.PluginInformation.Dependencies)
            {
                Console.WriteLine("+- " + dep.Name + " - " + dep.Version.Number);
            }


            if (!PluginPackageManager.IsWindowsVersionSupported(_Plugin.PluginInformation.Compatibility.Windows.MinVersion))
            {
                this.Invoke(new Action(() =>
                {
                    bntInstall.Enabled = false;
                    lblError.Text = $"Youre Windows is not compatible with the plugin. 0x{INSTALLER_CODES.INVALID_DATA.ToString("X")}";
                    lblError.Visible = true;
                    lblFunctionList.Visible = false;
                    lblFunctions.Visible = false;

                }));
            }

        });
    }

    private void sButton1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("LILO Plugin Installer for \"Crypterv2\".\n\nVersion: " + Program.Version, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        try
        {
            OpenInApp(new InstallerInfoDialog(), "Info", ChildrenUse.Auth);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private Form currentOpenedApp;

    public void OpenInApp(Form children, string FormName = null, ChildrenUse usage = ChildrenUse.WebView)
    {

        if (children == currentOpenedApp) return;

        if (currentOpenedApp is not null)
        {
            currentOpenedApp.Close();
        }

        pnlChild.Visible = true;
        this.IsMdiContainer = true;
        this.BackColor = Color.White;

        children.MdiParent = this;
        pnlChild.Controls.Add(children);
        pnlChild.BringToFront();
        children.Dock = DockStyle.Fill;

        if (FormName is not null or "") children.Text = FormName;

        children.Show();
        children.BringToFront();

        currentOpenedApp = children;

        currentOpenedApp.FormClosing += (sender, e) =>
        {
            this.IsMdiContainer = false;
            this.BackColor = Color.White;
            pnlChild.Visible = false;
        };
    }

    private void bntInstall_Click(object sender, EventArgs e)
    {
        if (bntInstall.Text is not "Close")
        {
            InstallMode(true);

            Task.Run(async () =>
            {

                var response = await PluginPackageManager
                .ExtractPluginWithAssets(_Plugin.PluginPackageFile,
                                                            _Plugin.TempDirectory,
                                                             _Plugin.PluginInformation,
                 (e, s) =>
                 {
                     this.Invoke(new Action(() =>
                     {
                         lblProgressDescription.Text = s;
                         progress.Value = e;
                     }));
                 });

                if (response.ResponseCode == INSTALLER_CODES.SUCCESS)
                {
                    Directory.CreateDirectory(MainHost._PluginDirectory + $"\\{_Plugin.PluginInformation.Name}");

                    var reponsse = await PluginPackageManager.CopyToPluginRepo(response, MainHost._PluginDirectory + $"\\{_Plugin.PluginInformation.Name}", (e, s) =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            lblProgressDescription.Text = s;
                            progress.Value = e;
                        }));
                    });

                    if (reponsse == INSTALLER_CODES.SUCCESS)
                    {
                        InstallMode(false);
                        bntInstall.Text = "Close";
                        this.Text = "Installed Successfull";
                    }
                }
                else
                {
                    InstallMode(false);

                    lblError.Text = $"Install Error. 0x{response.ResponseCode.ToString("X")}";
                    lblError.Visible = true;
                }
            });
        }
        else
        {
            string Restartsrcipt = $"@echo off\r\nsetlocal\r\n\r\n:: Define the number of seconds to wait\r\nset \"wait_seconds=10\"\r\n\r\n:: Display a countdown message\r\nfor /l %%i in (%wait_seconds% -1 1) do (\r\n    cls\r\n    echo Waiting for %%i seconds...\r\n    timeout /t 1 /nobreak >nul\r\n)\r\n\r\n:: Start your application here\r\nstart \"\" \"{Application.ExecutablePath}\"\r\n\r\nendlocal";
            Application.Exit();
        }

    }

    private void pnlPluginIcon_Click(object sender, EventArgs e)
    {
        PluginIconDialog.ShowPluginIcon(_Plugin.PluginIcon);
    }

    private void lblFunctionList_Click(object sender, EventArgs e)
    {
        PluginFeatureList.ShowFeatureList(sb.ToString());
    }
}
