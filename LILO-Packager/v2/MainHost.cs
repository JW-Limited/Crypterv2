using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.LILO;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Core.Visuals;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Plugins.Model;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Streaming.MusikPlayer.Forms;
using LILO_Packager.v2.Shared.Api.Core;
using LILO_Packager.v2.Shared.Types;
using LILO_Packager.v2.Shared.Streaming.Core;
using LILO_Packager.v2.Core.LILO.Types;
using LILO_Packager.v2.Core.BugBarrier;
using System.Collections.ObjectModel;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using srvlocal_gui.AppMananger;


namespace LILO_Packager.v2;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class MainHost : System.Windows.Forms.Form, ILILOMainHost
{
    #region Variables

    public readonly ThemeManager _thManager;
    private readonly BroadcastChannel _broadCastChannel;
    private readonly TcpListener _listener;
    private readonly Thread _listenerThread;
    private readonly LILO_WebEngine.Service.LocalServer _localServer;
    public readonly NotifyIconManager _noty;
    public readonly PluginManagerv2 _pluginManager;
    public UserAdvanced _userAdvanced;
    public bool PresedExit = false;

    public readonly string ThemePath = Path.Combine(Application.ExecutablePath.Replace("crypterv2.exe", ""), "themes");
    public readonly string Owner = "JW-Limited";
    public static readonly string _PluginDirectory = Application.ExecutablePath.Replace("crypterv2.exe", "") + "plugins";
    public readonly string Repository = "Crypterv2";
    public readonly string ZipPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "latest_release.zip");

    private static MainHost _hostInstance;
    public static Form _currentOpenedApp;
    private static object _lock = new object();

    public string htmlCode { get; set; }
    public string name { get; set; }
    public string version { get; set; }
    public bool updating = false;
    public bool downloaded = false;
    public string UserFile { get => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"); private set => UserFile = value; }
    public int Port = 8080;

    public Action<bool> isEnabling;
    public User loggedInUser;

    public Core.History.DatabaseHandling dataHandler = new Core.History.DatabaseHandling();
    public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();

    

    private Dictionary<string, bool> GetFeaturesAndValues()
    {
        return Enum.GetValues(typeof(FeatureFlags)).Cast<FeatureFlags>()
            .Select(feature => new KeyValuePair<string, bool>(feature.ToString(), FeatureManager.IsFeatureEnabled(feature)))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }


    #endregion

    #region Debug Socket

    private async Task HandleClientAsync(object clientObj)
    {
        using (TcpClient client = (TcpClient)clientObj)
        using (NetworkStream stream = client.GetStream())
        using (StreamReader reader = new StreamReader(stream))
        using (StreamWriter writer = new StreamWriter(stream))
        {
            string command = reader.ReadLine();
            
            if(command is not null)
            {
                if (command.ToLower() == "list")
                {
                    writer.WriteLine(JsonConvert.SerializeObject(GetFeaturesAndValues()));
                    await writer.FlushAsync();
                }
                else if (command.ToLower() == "closeThread")
                {
                    Application.ExitThread();
                }
                else
                {
                    if (Enum.TryParse(command, true, out FeatureFlags feature))
                    {
                        writer.WriteLine($"Toggled:{command}");
                        await FeatureManager.ToggleFeatureAsync(feature);
                    }
                    else
                    {
                        writer.WriteLine($"CommandNotFound:{command}");
                        await writer.FlushAsync();
                        Console.WriteLine($"Invalid command received: {command}");
                    }
                }
            }
        }
    }

    private async void ListenForConnections()
    {
        while (true && !MainHost.Instance().PresedExit)
        {
            try
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                ThreadPool.QueueUserWorkItem(async (obj) =>
                {
                    try
                    {
                        await HandleClientAsync(obj);
                    }
                    catch(Exception ex)
                    {
                        BugBarrier.HandleException(ex);
                    }
                }
                , client);
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor($"Error accepting client connection: {ex.Message}",ConsoleColor.DarkRed);
            }
        }

        if (MainHost.Instance().PresedExit)
        {
            Application.ExitThread();
        }
    }

    private async void FeatureFlagEvents_FeatureFlagUpdateRequested(object? sender, FeatureFlagUpdateEventArgs e)
    {
        await FeatureManager.ToggleFeatureAsync(e.Flag);
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
            if (_hostInstance is null)
            {
                _hostInstance = new MainHost();
                Program.InstanceCacheContainer.Register<ILILOMainHost>(() => _hostInstance);
            }

            return _hostInstance;
        }
    }

    public Stopwatch InitTimer = new Stopwatch();

    private unsafe MainHost()
    {
        InitTimer.Start();

        InitializeComponent();

        _broadCastChannel = BroadcastChannel.Instance;

        Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Initialized Broadcast Channel.");

        _broadCastChannel.Subscribe(new MainHostBroadCast());

        _broadCastChannel.BroadcastEvent += (sender, e) =>
        {
            ConsoleManager.Instance().WriteLineWithColor("[BROADCAST(Message)] Payload: " + e.Message.Payload ?? e.Message.BroadcastMessageArgs?.Message ?? "null");
        };

        _broadCastChannel.BroadCastSubscribeEvent += (sender, e) =>
        {
            ConsoleManager.Instance().WriteLineWithColor("[BROADCAST(Event)] Subscription: " + e.Subscriped.ToString() + " - Name: " + e.Observer + " - TotalCount: " + _broadCastChannel.ObserverCount);
        };

        _thManager = ThemeManager.Initialize();
        Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Initialized Thememanager.");

        _noty = NotifyIconManager.Instance();
        Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Initialized NotficationManager.");

        _pluginManager = new PluginManagerv2(_PluginDirectory);
        _localServer = LILO_WebEngine.Service.LocalServer.Instance;

        if (System.IO.File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json")))
        {
            Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Logging Registered User in.");
            loggedInUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));
            _userAdvanced = new UserAdvanced(loggedInUser);
        }

        if (!Directory.Exists(ThemePath)) Directory.CreateDirectory(ThemePath);

        if (FeatureFlagePipeLineConfig.DebugModeEnabled)
        {
            Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Opend Development-Config Port.");

            _listenerThread = new Thread(ListenForConnections);
            _listener = TcpListener.Create(9001);
            _listener.Start();

            try
            {
                _listenerThread.TrySetApartmentState(ApartmentState.MTA);
                _listenerThread.Start();
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
        _ = Task.Run(() => this.Invoke(async () =>
        {
            var updater = Updater.Instance();
            Program.InstanceCacheContainer.Register<IUpdater>(() => updater);

            foreach (var procSrv in Process.GetProcessesByName("srvlocal"))
            {
                procSrv.Kill();
            }

            FileOperations.CreateDirectoryRecursively(".\\log");

            var storageProvider = await StorageProvider.Create(".\\");
            if(storageProvider is not null) Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Initialized StorageProvider.");


            var response = await _localServer.Initialization(new LILO_WebEngine.Service.LocalServerOptions()
            {
                Port = new LILO_WebEngine.Shared.Port()
                {
                    Default = 8080,
                    FallBack = 8090
                },
                SourceDirectory = ".\\html",
                ApiKey = "liloDev-420",
                LogDirectory = ".\\log",
                ServerName = "Crypterv2",
            });

            if (response.SuccessFull)
            {
                Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Initialized LILO WebEngine.");

                var running = await _localServer.Start();
                Port = response.Port;

                Program.InstanceCacheContainer.Resolve<ILILOConsoleManager>().WriteLineWithColor($"[{GetDebuggerDisplay()}] - Started LILO WebEngine with Port: {response.Port}.");

                _localServer.OnLocalServerRequest += async (sender, e) =>
                {
                    ConsoleManager.Instance().WriteLineWithColor($"[LILO-WebEngine(Running: {e.IsRunning})] - {e.Message}");



                    if (e.ListenerContext.Request.Url.LocalPath.TrimStart('/').EndsWith("mp3") || e.Message.EndsWith("mp3"))
                    {
                        await OpenDynamicPlayer(e.ListenerContext, e.Message);
                    }
                };

                _localServer.OnError += (sender, e) =>
                {
                    OkDialog.Show("An internal Server Error happend.", e.ErrorFatality.ToString(), DialogIcon.Error);
                };
            }
            else
            {
                OkDialog.Show(response.ErrorMessage, "InternalServerErrror");
            }

            foreach (Control item in this.Controls)
            {
                if (item.Name == "pnlSide")
                {
                    _thManager.RegisterControl(item, ThemeManager.ModeType.Light, Color.LightGray, Color.Black);
                }

                _thManager.RegisterControl(item, ThemeManager.ModeType.Light, Color.White, Color.Black);
            }

            _thManager.ApplyTheme("White");
            _thManager.SaveThemesToJson(Path.Combine(ThemePath, "default.lcs"));

            if (config.Default.autoUpdates)
            {
                try
                {
                    pnlNothing.Visible = false;
                    pnlLoading.Visible = true;
                    var currentVersion = Program.Version.ToString();
                    var latestVersion = updater.GetLatestVersion(Owner, Repository);
                    var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

                    if (Semi.IsNewer)
                    {
                        _noty.ShowBubbleNotification(new Notification("Updater", $"A new release is available. \nYour Version : {currentVersion}\nLatest Version : {Semi.ToString()}"));
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
                    OpenInApp(new uiNetworkError("NetworkError", "The server didnt respond."));
                    pnlSide.Visible = false;
                    hider.Visible = false;
                }
            }


            await dataHandler.InitializeDatabaseAsync(process => { });


            await v2.Core.FeatureManager.LoadConfigurationAsync();

            if (config.Default.allowedPlugins)
            {
                try
                {
                    var responseScan = await _pluginManager.Scan();

                    foreach (var ele in _pluginManager.Pluginsv1)
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

                    if (responseScan.PluginsChanged)
                    {
                        foreach (var plug in responseScan.ChangedPlugins)
                        {
                           var pluginEntry = plugins.First(t => t.Name == plug.Plugin.Name);
                           uiPluginInformation.ShowDialog(pluginEntry);
                        }

                    }

                    ConsoleManager.Instance().WriteLineWithColor($"[PLUGIN-MANAGER] - Plugins Loaded (Count: {plugins.Count} / Errors: 0)");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.Source + ex.StackTrace, "Mainhost: PluginManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

            pnlChild.BackgroundImage = null;
            await Task.Delay(500);


            InitTimer.Stop();

            ConsoleManager.Instance().WriteLineWithColor($"Init Time: {InitTimer.Elapsed.TotalSeconds}sec");

            this.Invoke(() =>
            {
                splash_Panel.Visible = false;
                prgMiniProgress.Visible = false;
                hider.Visible = true;
            });


            if (!File.Exists(UserFile))
            {
                OpenInApp(new uiLILOLogin());
                pnlSide.Visible = false;
                hider.Visible = false;
            }
            else
            {
                OpenInApp(v2.Forms.uiWebView.Instance(new Uri($"http://localhost:{Port}")));
            }

            await Task.Run(async () =>
            {
                await Crypterv2.WatchdogUtilty.ServiceEngine.Instance.StartAsync(Port, 30);
            }).ConfigureAwait(false);
        }));
        
    }

    #endregion

    #region Important Host Functions 

    public enum ChildrenUse
    {
        Auth,
        WebView,
        NormalForm
    }

    public void OpenInApp(Form children, string FormName = null, ChildrenUse usage = ChildrenUse.WebView)
    {
        if (!MainHost.Instance().IsDisposed)
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
    }

    public async Task OpenDynamicPlayer(HttpListenerContext con, string fallbackFile)
    {
        ConsoleManager.Instance().WriteLineWithColor("Opening LocalPlayer with Stream.");

        try
        {
            ConsoleManager.Instance().WriteLineWithColor("[PLAYER.Dynamic] - Requesting Information");

            var mediaPlayer = new uiPlayerDynamic(await MusicPlayerParameters.Get(con.Request.Url.AbsolutePath.TrimStart('/')), null, uiPlayerDynamic.DynamicPlayerOpendedForm.LILO_WebEngine);

            this.Invoke(delegate
            {
                OpenInApp(mediaPlayer);
                con.Response.Close();
            });
        }
        catch (Exception ex)
        {
            ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkMagenta);

            try
            {
                ConsoleManager.Instance().WriteLineWithColor("[PLAYER.Dynamic] - Requesting Fallback - Information");

                var fallback = new uiPlayerDynamic(await MusicPlayerParameters.Get(fallbackFile));

                this.Invoke(delegate
                {
                    OpenInApp(fallback);
                    con.Response.Close();
                });
            }
            catch (Exception ex2)
            {
                OkDialog.Show(ex2.Message, "Error: Stream Failure", DialogIcon.Error);
            }


        }

    }

    public void SetNotification(string Message)
    {
        Transition.Show(pnlNoti);
        lblMessage_Noti.Text = Message;
    }

    #endregion

    #region Button Events

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

    private async void bntOpenDevApp(object sender, EventArgs e)
    {
        //var ofd = new OpenFileDialog();
        //ofd.ShowDialog();

        //if (await new SmartFilePacker().CheckIfFileIsValid(ofd.FileName))
        //{
        //    var files = await new SmartFilePacker().GetZippedFileInfoAsync(ofd.FileName);
        //    Console.WriteLine(files.Package.Name + files.Application.Name + files.Application.Version);

        //    foreach (var file in files.Files)
        //    {
        //        Console.WriteLine(file.FilePath + file.Hash + "\n");
        //    }
        //}
        //else
        //{
        //    OkDialog.Show("This file was not packaged with this Application.", "Error");
        //}


        var sec = new uiSecureInputHandler(
            new Core.Dialogs.Secured.SecuredDialogPreferences(
                "AxcDialog", "AxKey", "Please Input youre wanted Encrypten Key")
            {
                Channel = BroadcastChannel.Instance
            });
        sec.ShowDialog();

        bntMenu(sender, e);
    }

    private void bntCloseNoti(object sender, EventArgs e)
    {
        pnlNoti.Visible = false;
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri($"http://localhost:{Port}/help/")));
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
        if (!pnlSide.Visible)
            Transition.Show(pnlSide);
        else
            pnlSide.Visible = false;
    }

    private void sPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri($"http://localhost:{Port}")));
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
            //OpenInApp(v2.Forms.uiPluginManager.Instance(plugins, _pluginManager));
            OpenInApp(v2.Forms.uiPluginManagerv2.Instance);
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
            bntAccount.Text = "    " + _userAdvanced.Name;
        }
    }

    private void bntAccount_MouseLeave(object sender, EventArgs e)
    {
        bntAccount.Text = "    Account";
    }

    #endregion

    #region Updater

    public async Task CheckForUpdates(UpdateMode mode = UpdateMode.Manual)
    {
        try
        {
            pnlNothing.Visible = false;
            pnlLoading.Visible = true;
            var updater = Updater.Instance();
            var currentVersion = Program.Version.ToString();
            var latestVersion = updater.GetLatestVersion(Owner, Repository);
            var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

            if (Semi.IsNewer)
            {
                _noty.ShowBubbleNotification(new Notification("Updater", $"A new release is available. \nYour Version : {currentVersion}\nLatest Version : {Semi.ToString()}"));
                pnlNotifications.Visible = true;
            }
            else if (!Semi.IsNewer)
            {
                _noty.ShowBubbleNotification(new Notification("Updater", $"Youre on the latest Version ;)\nYour Version : {currentVersion}\nLatest Version : {Semi.ToString()}"));
            }
        }
        catch (System.AggregateException ex)
        {
            ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkRed);

            _noty.ShowBubbleNotification(new Notification("Updater", $"Network Error :("));
        }
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
                        updater.VerifyAndExtractZip(ZipPath, "8a3a0cecf50f9e4a7387b23d4a4c4e4b3d2bbd8e91edc5729c15f9f1f10c8aaf", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "JW Limited"),
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

                    updater.DownloadLatestRelease(Owner, Repository, UpdateProgress);
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

    public void guna2Button6_Click_1(object sender, EventArgs e)
    {
        try
        {
            pnlNothing.Visible = false;
            pnlLoading.Visible = true;
            var updater = Updater.Instance();
            var currentVersion = Program.Version.ToString();
            var latestVersion = updater.GetLatestVersion(Owner, Repository);
            var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

            if (Semi.IsNewer)
            {
                _noty.ShowBubbleNotification(new Notification("Updater", $"A new release is available. \nYour Version : {currentVersion}\nLatest Version : {Semi.ToString()}"));
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
            OpenInApp(new uiNetworkError("NetworkError", "The server didnt respond."));
            pnlSide.Visible = false;
            hider.Visible = false;
        }
    }

    private void bntUpdate(object sender, EventArgs e)
    {
        var updater = Updater.Instance();
        var currentVersion = Program.Version.ToString();
        var latestVersion = updater.GetLatestVersion(Owner, Repository);
        var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

        hider.Visible = false;
        pnlSide.Visible = false;
        pnlNotifications.Visible = false;
        this.Text = "Updater";
        OpenInApp(new v2.Forms.uiUpdater(Semi));
    }

    private string GetDebuggerDisplay()
    {
        return "MainHost(1/2)";
    }

    #endregion

    private void hider_Paint(object sender, PaintEventArgs e)
    {

    }
}
