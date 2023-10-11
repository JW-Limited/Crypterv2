using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Plugins.ThirdParty.Core;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using System.Diagnostics;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPluginStore : Form, ILILOPluginStore
    {
        private static uiPluginStore _instance;
        private ILILOPackageDownloader _downloader;

        public static uiPluginStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uiPluginStore();
                    Program.InstanceCacheContainer.Register<ILILOPluginStore>(() => _instance);
                }

                return _instance;

            }
        }

        public uiPluginStore()
        {
            InitializeComponent();

            _downloader = new PackageDownloader();

            this.FormClosing += (s, e) =>
            {
                e.Cancel = true;
                this.Hide();
            };
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            Program.InstanceCacheContainer.Resolve<ILILOMainHost>().OpenInApp(uiPluginManager.Instance(null, null));
        }

        private void uiPluginStore_Load(object sender, EventArgs e)
        {
            pnlNetworkError.Visible = !_downloader.HasNetworkConnection();
            Program.InstanceCacheContainer.Register<ILILOPackageDownloader>(() =>  _downloader);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void encryptenPlugin_ClickedDownload(object sender, EventArgs e)
        {
            progress.Visible = true;
            progress.Value = 0;
            Directory.CreateDirectory(".\\temp");

            _downloader.ProgressChanged += (s, e) =>
            {
                progress.Value = (int)e.Percentage;
            };

            Task.Run(async () =>
            {
                await _downloader.DownloadAsync(PluginDownloadLinks.Get(PluginDownloadLinks.Plugin.EncLib), "temp\\EncLib.cryptex");

                await Task.Delay(1000);

                Process.Start("crypterv2.exe", "temp\\EncLib.cryptex");

                this.Invoke(new Action(() =>
                {
                    progress.Visible = false;
                }));
            });

        }

        private void plainPlugin_ClickedDownload(object sender, EventArgs e)
        {
            progress.Visible = true;
            progress.Value = 0;
            Directory.CreateDirectory(".\\temp");

            _downloader.ProgressChanged += (s, e) =>
            {
                progress.Value = (int)e.Percentage;
            };

            Task.Run(async () =>
            {
                await _downloader.DownloadAsync(PluginDownloadLinks.Get(PluginDownloadLinks.Plugin.PlainLib), "temp\\PlainLib.cryptex");

                await Task.Delay(1000);

                Process.Start("crypterv2.exe", "temp\\PlainLib.cryptex");

                this.Invoke(new Action(() =>
                {
                    progress.Visible = false;
                }));
            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlNetworkError.Visible = !_downloader.HasNetworkConnection();
        }
    }
}
