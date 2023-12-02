using Crypterv2.DevTool.Core;
using Crypterv2.DevTool.Core.Forms;
using Crypterv2.DevTool.Core.Types;
using Crypterv2_DevTool.Core;
using Crypterv2_DevTool.Core.Forms;
using LILO_Packager.v2.Core;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using LILO_Packager.v2.Shared;
using Paket;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Crypterv2_DevTool
{
    public partial class MainHost : Form
    {
        public TcpClient Client;

        public Dictionary<string, bool> Features = new Dictionary<string, bool>();

        private Dictionary<FeatureFlags, string> descriptions = new Dictionary<FeatureFlags, string>
        {
            { FeatureFlags.NewEncryptionCore,           "Aktiviert den neuen Verschlüsselungskern, um sicherzustellen, dass Ihre sensiblen Daten mit modernsten Sicherheitsmethoden geschützt sind." },
            { FeatureFlags.PluginSupport,               "Ermöglicht die Unterstützung von Plugins in Form von .dll-Dateien. Diese Erweiterbarkeit ermöglicht es Ihnen, zusätzliche Funktionen und Integrationen nahtlos in Crypterv2 einzuführen." },
            { FeatureFlags.ThirdPartyPluginSupport,     "Ermöglicht die Unterstützung von Plugins von Drittanbietern. Sie können nun von externen Entwicklern erstellte Erweiterungen in Crypterv2 integrieren." },
            { FeatureFlags.PluginManager,               "Aktiviert den Plugin-Manager, der Ihnen ermöglicht, Plugins zu verwalten, zu installieren und zu deaktivieren, ohne die Hauptanwendung neu starten zu müssen." },
            { FeatureFlags.WebView2GraphicalContent,    "Ermöglicht die Anzeige von grafischem Inhalt in WebView2. Dies passiert in einer integrierten Browserkomponente."},
            { FeatureFlags.SecuredContainerStreaming,   "Ermöglicht das Streaming von verschlüsselten Inhalten. Diese Funktion gewährleistet, dass vertrauliche Daten sicher übertragen werden, ohne die Integrität der Verschlüsselung zu beeinträchtigen." },
            { FeatureFlags.HistoryElementQuering,       "Ermöglicht das Abfragen von Verlaufsdaten, sodass Sie präzise Einblicke in frühere Aktivitäten und Aktionen innerhalb Crypterv2 erhalten können." }
        };
        private static MainHost _instance;
        public static MainHost GetInstance()
        {
            if (_instance is null)
            {
                _instance = new MainHost();
            }

            return _instance;
        }

        private MainHost()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var state = new object();

                Features.Clear();

                Client = new TcpClient();


                ConsoleManager.Instance().WriteLineWithColor("Begin Lazy.Async.Connect to Crypter-DevPort.");

                var result = Client.BeginConnect(IPAddress.Loopback, 9001, callback =>
                {
                    //ConsoleManager.Instance().WriteLineWithColor("Begin Connect callback: " + Client.+ " Task Completed:" + callback.IsCompleted);
                }, state);

                ConsoleManager.Instance().WriteLineWithColor("Accomplished Connection.");


                this.Text = "DevTool - Bridged";
                this.button1.Text = "Connected";
                this.button1.Visible = false;

                var feat = new FeatureFlag();

                listViewHistory.Items.Clear();

                var features = feat.ListFeaturesViaConnectedSocket(Client);


                ConsoleManager.Instance().WriteLineWithColor("Feched Featurelist from MainHost.");

                foreach (var kv in features)
                {
                    var item = new ListViewItem()
                    {
                        Text = $"{kv.Key}",
                    };

                    item.SubItems.Add(kv.Value.ToString());
                    listViewHistory.Items.Add(item);

                    Features.TryAdd(kv.Key, kv.Value);
                }

                lblClient.Text = Client.Client.SocketType.ToString();
                lblState.Text = $"Available";
                lblDebug.Text = "True";
                lblCore.Text = "HyperCFTP";
                lblVersion.Text = Application.ProductVersion.ToString();
                lblAccess.Text = "Unknown";
                bntDisconnect.Visible = true;

                pnlErrorConnection.Visible = false;
            }
            catch
            {


                pnlErrorConnection.Visible = true;

                this.button1.Text = "Retry";
                this.button1.Visible = true;
                this.Text = "DevTool - Error";
            }
        }

        public enum ChildrenUse
        {
            Auth,
            WebView,
            NormalForm
        }

        private Form currentOpenedApp;

        /// <summary>
        /// This Method accpets a WinForm object and 
        /// displays it over all controls with help of
        /// a Panel
        /// </summary>
        /// <param name="children">
        /// The Form Object
        /// </param>
        /// <param name="FormName">
        /// The displayed Formname
        /// </param>
        /// <param name="usage">
        /// The Mode and Accessability clarifier
        /// </param>

        public void OpenInApp(Form children, string FormName = null, ChildrenUse usage = ChildrenUse.WebView)
        {

            if (children == currentOpenedApp) return;

            if (currentOpenedApp is not null)
            {
                currentOpenedApp.Close();
            }

            this.Text = "Crypterv2 - " + FormName;
            this.IsMdiContainer = true;
            this.BackColor = Color.White;

            children.MdiParent = this;
            pnlChild.Controls.Add(children);
            pnlChild.Dock = DockStyle.Fill;
            pnlChild.BringToFront();

            if (usage == ChildrenUse.Auth)
            {
                children.MaximizeBox = false;
                children.MinimizeBox = false;
                children.ControlBox = false;
                children.FormBorderStyle = FormBorderStyle.None;
            }
            else if (usage == ChildrenUse.WebView)
            {
                children.FormBorderStyle = FormBorderStyle.Sizable;
                children.MaximizeBox = false;
                children.MinimizeBox = false;
            }
            else if (usage == ChildrenUse.NormalForm)
            {
                children.FormBorderStyle = FormBorderStyle.Sizable;
                children.MaximizeBox = false;
                children.MinimizeBox = false;
                this.Size = children.Size;
            }

            children.Dock = DockStyle.Fill;

            if (FormName is not null or "") children.Text = FormName;


            children.Show();

            currentOpenedApp = children;

            currentOpenedApp.FormClosing += (sender, e) =>
            {
                this.IsMdiContainer = false;
                this.BackColor = Color.White;
                pnlChild.Dock = DockStyle.None;
                pnlChild.Size = new Size(1, 1);
                this.Text = "Crypterv2 - Bridged";

            };
        }

        public async void Main_Load(object sender, EventArgs e)
        {
            lblBottom.Text = $"{LILO_Packager.Program.Version} - (0.11)\r\nJW Limited © 2023\r\n";
            try
            {

                pnlErrorConnection.Visible = false;
                var state = new object();

                Features.Clear();

                Client = new TcpClient();

                ConsoleManager.Instance().WriteLineWithColor("Begin Lazy.Async.Connect to Crypter-DevPort.");

                var result = Client.BeginConnect(IPAddress.Loopback, 9001, callback =>
                {
                    //ConsoleManager.Instance().WriteLineWithColor("Begin Connect callback: " + Client.+ " Task Completed:" + callback.IsCompleted);
                }, state);

                ConsoleManager.Instance().WriteLineWithColor("Accomplished Connection.");

                this.Text = "DevTool - Bridged";
                this.button1.Text = "Connected";
                this.button1.Visible = false;
                this.bntDisconnect.Visible = true;

                var feat = new FeatureFlag();

                listViewHistory.Items.Clear();

                var features = feat.ListFeaturesViaConnectedSocket(Client);


                ConsoleManager.Instance().WriteLineWithColor("Feched Featurelist from MainHost.");

                foreach (var kv in features)
                {
                    var item = new ListViewItem()
                    {
                        Text = $"{kv.Key}",
                    };

                    item.SubItems.Add(kv.Value.ToString());
                    listViewHistory.Items.Add(item);

                    Features.TryAdd(kv.Key, kv.Value);
                }

                lblClient.Text = Client.Client.SocketType.ToString();
                lblState.Text = $"Available";
                lblDebug.Text = "True";
                lblCore.Text = "HyperCFTP";
                lblVersion.Text = Application.ProductVersion.ToString();
                lblAccess.Text = "Unknown";
                bntDisconnect.Visible = true;
            }
            catch
            {
                pnlErrorConnection.Visible = true;
                this.button1.Text = "Retry";
                this.button1.Visible = true;
                this.bntDisconnect.Visible = false;
                this.Text = "DevTool - Error";
                MessageBox.Show("Cant connect to Crypterv2.", "DevConnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void listViewHistory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = listViewHistory.SelectedItems[0].Text;

                if (Features.ContainsKey(selectedItem))
                {
                    var flag = (FeatureFlags)Enum.Parse(typeof(FeatureFlags), selectedItem);
                    descriptions.TryGetValue(flag, out string descriptionValue);
                    Features.TryGetValue(selectedItem, out bool enabled);

                    var flagInfo = new FlagInfo()
                    {
                        Name = selectedItem,
                        Flag = flag,
                        Description = descriptionValue,
                        EnabledState = enabled

                    };

                    var detailViewUi = new Core.Forms.uiListElement(flagInfo, Client);

                    OpenInApp(detailViewUi, "QuickView", ChildrenUse.Auth);
                }
            }
            catch (System.ArgumentException ex)
            {

                var dialogtest = new uiCustomDialog(
                new LILO_Packager.v2.Core.Dialogs.MessageDialogPreference(
                    "Resolving Error",
                    "We had trouble to resolve this feature. You need to update this application.\n\nShould we do it now?",
                    LILO_Packager.v2.Core.Dialogs.Dialog.Authorization,
                    LILO_Packager.v2.Core.Dialogs.DialogButtons.Authorization,
                    LILO_Packager.v2.Core.Dialogs.DialogIcon.Question,
                    result =>
                    {
                        if (result == LILO_Packager.v2.Core.Dialogs.DialogResults.Ok)
                        {
                            string url = "https://github.com/JW-Limited/Crypterv2/releases";

                            Process.Start(new ProcessStartInfo
                            {
                                FileName = url,
                                UseShellExecute = true
                            });
                        }
                    })
                );
                dialogtest.ShowDialog();
            }
        }

        private void bntDisconnect_Click(object sender, EventArgs e)
        {
            ConsoleManager.Instance().WriteLineWithColor("Closed Stream/Connection to MainHost.");
            Client.Close();
            button1.Visible = true;
            bntDisconnect.Visible = false;
            listViewHistory.Items.Clear();
            lblAccess.Text = "n/a";
            lblDebug.Text = "n/a";
            lblVersion.Text = "n/a";
            lblState.Text = "n/a";
            lblCore.Text = "n/a";
            lblClient.Text = "n/a";
        }

        private void bntPlugins_Click(object sender, EventArgs e)
        {
            uiPluginKit.Instance().Text = this.Text;
            uiPluginKit.Instance().Icon = this.Icon;
            OpenInApp(uiPluginKit.Instance(), "Plugin TestKit", ChildrenUse.Auth);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void bntPackages_Click(object sender, EventArgs e)
        {
            
        }
    }
}
 