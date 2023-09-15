using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.LILO;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Core.ColorManager;
using LILO_Packager.v2.shared;
using LILO_Packager.v2.plugins.PluginCore;
using LILO_Packager.v2.plugins.Model;
using System.Collections.ObjectModel;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using srvlocal_gui.AppMananger;
using IWshRuntimeLibrary;

namespace LILO_Packager.v2;
public partial class MainHost : System.Windows.Forms.Form, IFeatureFlagSwitcher
{
    #region Variables

    public ThemeManager _thManager;
    private Form _currentOpenedApp;
    private static object _lock = new object();
    public string owner = "JW-Limited";
    public string repo = "Crypterv2";
    public string htmlCode { get; set; }
    public string name { get; set; }
    public string version { get; set; }
    public bool updating = false;
    public bool downloaded = false;
    public string UserFile { get => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"); private set => UserFile = value; }
    public string zipPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "latest_release.zip");
    public Action<bool> isEnabling;
    private static MainHost instance;
    private TcpListener listener;
    public PluginManager manager = null;
    public User loggedInUser;
    public string _ThemePath = Path.Combine(Application.ExecutablePath.Replace("crypterv2.exe", ""), "themes");
    public NotifyIconManager noty;
    public Core.History.DatabaseHandling dataHandler = new Core.History.DatabaseHandling();
    public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();

    public enum ChildrenUse
    {
        Auth,
        WebView,
        NormalForm
    }

    private Dictionary<string, bool> GetFeaturesAndValues()
    {
        Dictionary<string, bool> featureValues = new Dictionary<string, bool>
        {
            { FeatureFlags.NewEncryptionCore.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.NewEncryptionCore) },
            { FeatureFlags.PluginSupport.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.PluginSupport) },
            { FeatureFlags.ThirdPartyPluginSupport.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.ThirdPartyPluginSupport) },
            { FeatureFlags.PluginManager.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.PluginManager) },
            { FeatureFlags.WebView2GraphicalContent.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.WebView2GraphicalContent) },
            { FeatureFlags.SecuredContainerStreaming.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.SecuredContainerStreaming) },
            { FeatureFlags.HistoryElementQuering.ToString(), FeatureManager.IsFeatureEnabled(FeatureFlags.HistoryElementQuering) }
        };


        return featureValues;
    }

    #endregion

    #region Debug Socket

    private async void HandleClient(object clientObj)
    {
        using (TcpClient client = (TcpClient)clientObj)
        using (NetworkStream stream = client.GetStream())
        using (StreamReader reader = new StreamReader(stream))
        using (StreamWriter writer = new StreamWriter(stream))
        {
            string command = reader.ReadLine();

            if (command.ToLower() == "list")
            {
                Dictionary<string, bool> featureValues = GetFeaturesAndValues();

                string featureValuesJson = JsonConvert.SerializeObject(featureValues);
                writer.WriteLine(featureValuesJson);
                writer.Flush();
            }
            else if (command.ToLower() == "closeThread")
            {
                Application.ExitThread();
            }
            else
            {

                var feature = (FeatureFlags)Enum.Parse(typeof(FeatureFlags), command);

                await FeatureManager.ToggleFeatureAsync(feature);
            }


        }
    }

    private void ListenForConnections()
    {
        while (true)
        {
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                ThreadPool.QueueUserWorkItem(HandleClient, client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private async void FeatureFlagEvents_FeatureFlagUpdateRequested(object? sender, FeatureFlagUpdateEventArgs e)
    {
        await FeatureManager.ToggleFeatureAsync(e.Flag);
    }

    public static void SetInstanceEqual(object newInstance)
    {
        if (newInstance.Equals(typeof(MainHost)))
        {
            instance = (MainHost)newInstance;
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(newInstance));
        }
    }

    public static void UpdateFeatureFlagFromHost(FeatureFlags feature, bool isEnabled)
    {
        FeatureFlagEvents.OnFeatureFlagUpdateRequested(feature, isEnabled);
    }

    #endregion

    #region Loading Tasks

    public static MainHost Instance()
    {
        lock (_lock)
        {
            if (instance is null)
            {
                instance = new MainHost();
            }

            return instance;
        }
    }

    private MainHost()
    {
        InitializeComponent();

        _thManager = ThemeManager.Initialize();
        noty = NotifyIconManager.Instance();

        if (System.IO.File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json")))
        {
            loggedInUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));
        }

        if (!Directory.Exists(_ThemePath)) Directory.CreateDirectory(_ThemePath);

        if (FeatureFlagePipeLineConfig.DebugModeEnabled)
        {
            Thread listenerThread = new Thread(ListenForConnections);
            listener = new TcpListener(IPAddress.Loopback, 9001);
            listener.Start();

            try
            {
                listenerThread.TrySetApartmentState(ApartmentState.MTA);
                listenerThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FeatureFlagEvents.FeatureFlagUpdateRequested += FeatureFlagEvents_FeatureFlagUpdateRequested;

        }

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = true;
            this.Hide();
        };
    }


    private async void MainHost_Load(object sender, EventArgs e)
    {
        var updater = Updater.Instance();

        var proc = new Process()
        {
            StartInfo = new ProcessStartInfo()
            {
                FileName = Application.ExecutablePath.Replace("crypterv2.exe", "") + "srvlocal\\srvlocal.exe",
                Arguments = "--folder=" + Application.ExecutablePath.Replace("crypterv2.exe", "") + "html",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            }
        };

        foreach (Control item in this.Controls)
        {
            if (item.Name == "pnlSide")
            {
                _thManager.RegisterControl(item, ThemeManager.ModeType.Light, Color.LightGray, Color.Black);
            }

            _thManager.RegisterControl(item, ThemeManager.ModeType.Light, Color.White, Color.Black);
        }

        _thManager.ApplyTheme("White");
        _thManager.SaveThemesToJson(Path.Combine(_ThemePath, "default.lcs"));

        foreach (var procSrv in Process.GetProcessesByName("srvlocal"))
        {
            procSrv.Kill();
        }

        proc.Start();


        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));

        if (config.Default.autoUpdates)
        {
            try
            {
                pnlNothing.Visible = false;
                pnlLoading.Visible = true;
                var currentVersion = Program.Version.ToString();
                var latestVersion = updater.GetLatestVersion(owner, repo);
                var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

                if (Semi.IsNewer)
                {
                    noty.ShowBubbleNotification(new LILO_Packager.v2.shared.Notification("Updater", $"A new release is available. \nYour Version : {currentVersion}\nLatest Version : {Semi.ToString()}"));
                    pnlNotifications.Visible = true;

                    pnlMes1.Visible = true;
                    Mes1_Title.Text = "Update";
                    Mes1_Message.Text = "A new Update is availlable.\nNewest: " + Semi.ToString();
                    Mes1_bnt.Text = "Update";
                }
                else if (!Semi.IsNewer)
                {
                    pnlNothing.Visible = true;
                }


            }
            catch (System.AggregateException ex)
            {
                ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkRed);

                OpenInApp(new uiFeatureNullException("NetworkError", "The server didnt respond."));

                pnlSide.Visible = false;

                hider.Visible = false;
            }
        }
        else
        {
            OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));
        }


        if (config.Default.allowedPlugins)
        {
            manager = new PluginManager(Application.ExecutablePath.Replace("crypterv2.exe", "") + "plugins");

            try
            {
                foreach (var ele in manager.CurrentPlugins)
                {
                    PluginEntry ent = new PluginEntry(ele);
                    plugins.Add(ent);
                }

                StringBuilder stringBuilder = new StringBuilder();

                foreach (var item in plugins)
                {
                    stringBuilder.Append($"Plugin : {item.Name}\n" +
                                         $"Description : {item.Description}\n" +
                                         $"Version : {item.Version}\n\n");
                }

                ConsoleManager.Instance().WriteLineWithColor(stringBuilder.ToString(), ConsoleColor.Cyan);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mainhost: PluginManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            await dataHandler.InitializeDatabaseAsync(process =>
            {

            });


            await v2.Core.FeatureManager.LoadConfigurationAsync();
        }
    }

    #endregion

    #region Important Host Functions 

    public void OpenInApp(Form children, string FormName = null, ChildrenUse usage = ChildrenUse.WebView)
    {

        if (children == _currentOpenedApp) return;

        if (_currentOpenedApp is not null)
        {
            _currentOpenedApp.Close();
        }


        this.IsMdiContainer = true;
        this.BackColor = Color.White;

        children.MdiParent = this;
        pnlChild.Controls.Add(children);
        pnlChild.Dock = DockStyle.Fill;
        pnlChild.BringToFront();

        children.MaximizeBox = false;
        children.MinimizeBox = false;
        children.ControlBox = false;
        children.FormBorderStyle = FormBorderStyle.None;

        children.Dock = DockStyle.Fill;

        if (FormName is not null or "") children.Text = FormName;

        children.Show();

        _currentOpenedApp = children;
    }

    #endregion

    #region Hider Button Events

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080/help/")));
        //OpenInApp(new uiNews());
    }

    private void bntOpen_Click(object sender, EventArgs e)
    {
        PluginEntry encryptionLibrary = null;

        foreach (var plugin in plugins)
        {
            if (PluginID.IDtoString(plugin.ID) == PluginID.IDtoString(PluginID.GetID("enc", "lbl", "lvl01")))
            {
                encryptionLibrary = plugin;
            }
        }

        if (encryptionLibrary is not null)
        {
            var response = encryptionLibrary.PluginBase.Execute(null);

            if (response.HasError)
            {
                MessageBox.Show(response.Message + "\n\nID:" + response.MessageID);
            }
            else
            {
                OpenInApp(v2.Forms.uiEncryt.Instance(encryptionLibrary, dataHandler));
            }


        }
        else
        {
            MessageBox.Show($"Please Install the necessary Librarys to such operations.\n\nMissing EncryptionModelLibrary.{encryptionLibrary.ID.ToString() + PluginID.GetID("enc", "lbl", "lvl01").ToString()}", "PluginManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiDecrypt.Instance(dataHandler));
    }

    private void lblText_Click(object sender, EventArgs e)
    {
        pnlSide.Visible = !pnlSide.Visible;
    }

    private void sPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        if (!FeatureManager.IsFeatureEnabled(FeatureFlags.HistoryElementQuering))
        {
            OpenInApp(new uiFeatureNullException("FeatureNullException", "This Feature is not availlabel."));
        }
        else
        {
            OpenInApp(v2.Forms.uiHistory.Instance());
        }

    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {


        if (loggedInUser is null)
        {
            var loginUi = uiLILOAccountLogin.Instance();
            loginUi.FormClosing += (sender, e) =>
            {
                if (System.IO.File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json")))
                {
                    loggedInUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));

                    OpenInApp(uiAccount.Instance(loggedInUser));
                }
            };

            loginUi.ShowDialog();
        }
        else
        {
            OpenInApp(v2.Forms.uiAccount.Instance(loggedInUser));
        }
    }

    private void bntPlugin_Clicked(object sender, EventArgs e)
    {
        if (!FeatureManager.IsFeatureEnabled(FeatureFlags.PluginManager) || !FeatureManager.IsFeatureEnabled(FeatureFlags.PluginSupport))
        {
            OpenInApp(new uiFeatureNullException("(FeatureNullException)", "This feature is not activated right now."));
        }
        else
        {
            OpenInApp(v2.Forms.uiPluginManager.Instance(plugins, manager));
        }

    }

    public void ToggleFeature(FeatureFlags feature, bool isEnabled)
    {
        FeatureFlagEvents_FeatureFlagUpdateRequested(null, new FeatureFlagUpdateEventArgs(feature, isEnabled));
    }

    private void guna2Button6_MouseHover(object sender, EventArgs e)
    {
        if (loggedInUser is not null)
        {
            bntAccount.Text = "    " + loggedInUser.Email.Replace("@jwlmt.com", "").ToUpperInvariant();
        }
    }

    private void bntAccount_MouseLeave(object sender, EventArgs e)
    {
        bntAccount.Text = "    Account";
    }

    #endregion

    #region Updater

    public Task CheckForUpdates(UpdateMode mode = UpdateMode.Manual)
    {
        try
        {
            var updater = Updater.Instance();

            var latestVersion = updater.GetLatestVersion(owner, repo);
            var latestChanges = updater.GetLatestChanges(owner, repo);
            var currentVersion = System.Windows.Forms.Application.ProductVersion;

            Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (updater.HasNewRelease(owner, repo))
                    {
                        Console.WriteLine("A new release is available.");

                        noty.ShowBubbleNotification(new LILO_Packager.v2.shared.Notification("Updater", $"A new release is available. \nYour Version : {currentVersion}\nLatest Version : {latestVersion}"));

                        //string html = Markdig.Markdown.ToHtml(latestChanges);

                    }
                    else
                    {
                        Console.WriteLine("No new release available.");

                        noty.ShowBubbleNotification(new LILO_Packager.v2.shared.Notification("Updater", $"No new release available.\nYou are perfect."));
                    }
                });

            });

            return Task.CompletedTask;
        }
        catch (Exception ex)
        {
            noty.ShowBubbleNotification(new LILO_Packager.v2.shared.Notification("Updater", ex.Message));
            return Task.CompletedTask;
        }
    }

    public static void CreateShortcut(string shortcutName, string targetFile)
    {
        string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\" + shortcutName + ".lnk";

        IWshShell wshShell = new WshShell();
        IWshShortcut shortcut = (IWshShortcut)wshShell.CreateShortcut(shortcutPath);

        shortcut.TargetPath = targetFile;
        shortcut.WorkingDirectory = Path.GetDirectoryName(targetFile);
        shortcut.WindowStyle = 1; // Normal window
        shortcut.Description = "Shortcut created using LAB Libary by JW Limited."; // Optional
        shortcut.IconLocation = targetFile + ",0"; // Optional

        shortcut.Save();
    }

    private async void bntUpdate_Click(object sender, EventArgs e)
    {
        var updater = Updater.Instance();

        try
        {
            if (downloaded)
            {
                isEnabling?.Invoke(false);
                this.ControlBox = false;
                updating = true;
                Text = "Installing Update...";

                await Task.Run(() =>
                {
                    try
                    {
                        // Call the API to verify and extract the ZIP file
                        updater.VerifyAndExtractZip(zipPath, "8a3a0cecf50f9e4a7387b23d4a4c4e4b3d2bbd8e91edc5729c15f9f1f10c8aaf", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "JW Limited"),
                        progress =>
                        {
                            if (progress == 100)
                            {
                                Task.Run(() =>
                                {
                                    Application.ExitThread();
                                });

                                Application.ExitThread();
                            }
                        },
                        error =>
                        {
                            MessageBox.Show($"Error: {error}", "Install Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Install Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

                MessageBox.Show("Installed Updates", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isEnabling?.Invoke(false);

                this.ControlBox = false;
                updating = true;

                await Task.Run(() =>
                {

                    updater.DownloadLatestRelease(owner, repo, UpdateProgress);
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.ControlBox = false;
                    });

                });
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            updating = false;
            downloaded = true;
            this.ControlBox = true;
        }


    }

    private void UpdateProgress(object sender, DownloadProgressChangedEventArgs e)
    {
        this.Invoke((MethodInvoker)delegate
        {
            //progessbar.Value = e.ProgressPercentage;
            this.Text = $"Downloading newest release {e.ProgressPercentage}%";

            if (e.ProgressPercentage == 100)
            {
                updating = false;
                downloaded = true;
                this.ControlBox = true;
                isEnabling?.Invoke(true);
            }
        });
    }

    private void guna2Button6_Click_1(object sender, EventArgs e)
    {

        try
        {
            pnlNothing.Visible = false;
            pnlLoading.Visible = true;
            var updater = Updater.Instance();
            var currentVersion = Program.Version.ToString();
            var latestVersion = updater.GetLatestVersion(owner, repo);
            var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

            if (Semi.IsNewer)
            {
                noty.ShowBubbleNotification(new LILO_Packager.v2.shared.Notification("Updater", $"A new release is available. \nYour Version : {currentVersion}\nLatest Version : {Semi.ToString()}"));
                pnlNotifications.Visible = true;

                pnlMes1.Visible = true;
                Mes1_Title.Text = "Update";
                Mes1_Message.Text = "A new Update is availlable.\nNewest: " + Semi.ToString();
                Mes1_bnt.Text = "Update";
            }
            else if (!Semi.IsNewer)
            {
                pnlNothing.Visible = true;
            }
        }
        catch (System.AggregateException ex)
        {
            ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkRed);

            OpenInApp(new uiFeatureNullException("NetworkError", "The server didnt respond."));

            pnlSide.Visible = false;

            hider.Visible = false;
        }
    }

    private void bntUpdate(object sender, EventArgs e)
    {
        var updater = Updater.Instance();
        var currentVersion = Program.Version.ToString();
        var latestVersion = updater.GetLatestVersion(owner, repo);
        var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

        hider.Visible = false;
        pnlSide.Visible = false;
        pnlNotifications.Visible = false;
        this.Text = "Updater";
        OpenInApp(new v2.Forms.uiUpdater(Semi));
    }

    #endregion

    public void SetNotification(string title, string Message)
    {

    }

    private void bntCloseSideBoard_Click(object sender, EventArgs e)
    {
        pnlSide.Visible = false;
    }



    private void bntChangeTheme(object sender, EventArgs e)
    {
        foreach (var theme in _thManager.Themes)
        {
            Console.WriteLine(theme.Key + ": " + theme.Value.ToString());
        }
        _thManager.ToggleDarkMode();
    }

    private void bntMenu(object sender, EventArgs e)
    {
        pnlMenu.Visible = !pnlMenu.Visible;
        bntMenu_c.Checked = !bntMenu_c.Checked;

    }

    private void bntOpenAboutPage(object sender, EventArgs e)
    {
        OpenInApp(new uiNews());
        bntMenu(sender, e);
    }

    private void bntAccount_DoubleClick(object sender, EventArgs e)
    {
        bntMenu(sender, e);
    }

    private void bntOpenDevApp(object sender, EventArgs e)
    {
        var dialogtest = new uiCustomDialog(
            new Core.Dialogs.MessageDialogPreference(
                "Test", 
                "TestMessage", 
                Core.Dialogs.Dialog.Authorization, 
                Core.Dialogs.DialogButtons.Authorization, 
                Core.Dialogs.DialogIcon.Information, 
                result => 
                {
                    if (result == Core.Dialogs.DialogResults.Ok)
                    {
                        MessageBox.Show("Hurray");
                    }
                })
            );
        dialogtest.ShowDialog();
        bntMenu(sender, e);
    }
}
