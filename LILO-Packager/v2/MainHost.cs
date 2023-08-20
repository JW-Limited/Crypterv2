using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LILO_Packager.Properties;
using LILO_Packager.v2.plugins.PluginCore;
using LILO_Packager.v2.plugins.Model;
using System.Collections.ObjectModel;
using Microsoft.FeatureManagement;
using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.Interfaces;
using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using Telerik.Pivot.Core;
using LILO_Packager.v2.Core.LILO;
using LILO_Packager.v2.Forms;

namespace LILO_Packager.v2;
public partial class MainHost : System.Windows.Forms.Form, IFeatureFlagSwitcher
{
    private static MainHost instance;
    private static object _lock = new object();
    private TcpListener listener;

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

    public enum ChildrenUse
    {
        Auth,
        WebView,
        NormalForm
    }
    public string UserFile { get => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"); private set => UserFile = value; }
    private PluginManager manager = null;
    public User loggedInUser;
    public Core.History.DatabaseHandling dataHandler = new Core.History.DatabaseHandling();
    public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();

    private MainHost()
    {
        InitializeComponent();

        if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json")))
        {
            loggedInUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));
        }

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
            OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:9001")));
        };
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
            else
            {
                string featureName = reader.ReadLine();

                var feature = (FeatureFlags)Enum.Parse(typeof(FeatureFlags), featureName);

                await FeatureManager.ToggleFeatureAsync(feature);
            }


        }
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

    private async void MainHost_Load(object sender, EventArgs e)
    {

        foreach (var procSrv in Process.GetProcessesByName("srvlocal"))
        {
            procSrv.Kill();
        }

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

        proc.Start();

        this.BackColor = SystemColors.ButtonFace;
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));

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

                // Just for Debug purposes because the Plugin Initializer 
                // gives often back a NullException or StackOverflow

                StringBuilder stringBuilder = new StringBuilder();

                foreach (var item in plugins)
                {
                    stringBuilder.Append($"Plugin : {item.Name}\n" +
                                         $"Description : {item.Description}\n" +
                                         $"Version : {item.Version}");
                }

                MessageBox.Show("We found Plugins and loaded them:\n\n" + stringBuilder.ToString(), "MainHost");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            await dataHandler.InitializeDatabaseAsync(process =>
            {

            });


            await v2.Core.FeatureManager.LoadConfigurationAsync();
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

        currentOpenedApp = children;
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080/help/")));
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
        OpenInApp(v2.Forms.uiHistory.Instance());
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    { 
        if(loggedInUser is null)
        {
            var loginUi = uiLILOAccountLogin.Instance();
            loginUi.FormClosing += (sender, e) =>
            {
                if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json")))
                {
                    loggedInUser = UserManager.Instance().LoadUserFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json"));
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
        OpenInApp(v2.Forms.uiPluginManager.Instance(plugins, manager));
    }

    public void ToggleFeature(FeatureFlags feature, bool isEnabled)
    {
        FeatureFlagEvents_FeatureFlagUpdateRequested(null, new FeatureFlagUpdateEventArgs(feature, isEnabled));
    }

    private void guna2Button6_MouseHover(object sender, EventArgs e)
    {
        if(loggedInUser is not null)
        {
            bntAccount.Text = "    " + loggedInUser.Email.Replace("@jwlmt.com", "").ToUpperInvariant();
        }
    }

    private void bntAccount_MouseLeave(object sender, EventArgs e)
    {
        bntAccount.Text = "    Account";
    }
}
