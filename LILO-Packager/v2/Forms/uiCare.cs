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

namespace LILO_Packager.v2.Forms
{
    public partial class uiCare : Form
    {
        private static uiCare _encrypt;
        private static object _lock = new object();
        public static uiCare Instance()
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new uiCare();
                }

                return _encrypt;
            }
        }

        public uiCare()
        {
            InitializeComponent();
        }

        public class CareValueState
        {
            public bool srvlocal_Runing { get; set; } = true;
            public bool debugmode_Enabled { get; set; } = false;
            public bool webviewCore_Runing { get; set; } = true;
            public bool notyIcon_showing { get; set; } = true;
            public bool mediaShowInApp { get; set; } = true;
        }

        private void uiCare_Load(object sender, EventArgs e)
        {

        }

        public async Task<CareValueState> AnalyzeStatus()
        {
            var values = new CareValueState();

            bntCancel.Text = "Analizing";

            if (Process.GetProcessesByName("srvlocal").Length < 1)
            {
                values.srvlocal_Runing = false;
            }

            Thread.Sleep(500);

            values.debugmode_Enabled = config.Default.debugMode;

            Thread.Sleep(500);

            if (!uiWebView.Instance(null).webView21.IsAccessible)
            {
                values.webviewCore_Runing = false;
            }

            Thread.Sleep(500);

            return values;
        }

        public async Task<bool> OptimizeApp(CareValueState care)
        {
            try
            {
                bntCancel.Text = "Optimizing";

                if (!care.srvlocal_Runing)
                {
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
                }

                if (care.debugmode_Enabled || !care.mediaShowInApp)
                {
                    config.Default.Reset();
                    config.Default.Save();
                }

                Thread.Sleep(600);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            if(bntCancel.Text == "Start")
            {
                progressSpinner.Visible = true;
                bntCancel.Text = "Running";
                bntCancel.Enabled = false;

                Task.Factory.StartNew(async () =>
                {
                    var status = await AnalyzeStatus();
                    var ready = await OptimizeApp(status);

                    if (ready)
                    {
                        lanb.Text = "Everything fine";
                        bntCancel.Text = "Close";
                        bntCancel.Enabled = true;
                        progressSpinner.Visible = false;
                        lblInfos.Text = "Fixed Errors:\n\n1. Local Interface Server Connection Rebooted\n2.Reseted Application Configs to default.";

                        uiWebView.Instance(null).webView21.Reload();
                    }
                });
            }
            else{
                _encrypt = null;
                this.Close();

            }
        }
    }
}
