using LILO_Packager.Properties;
using LILO_Packager.v2.Core.Authentication;
using LILO_Packager.v2.Core.LILO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Automation;


namespace LILO_Packager.v2.Forms
{
    public partial class uiAccount : Form
    {
        public User _user;
        private static uiAccount _encrypt;
        private static object _lock = new object();
        public static uiAccount Instance(User user)
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new uiAccount(user);
                }

                return _encrypt;
            }
        }

        private uiAccount(User user)
        {
            InitializeComponent();
            _user = user;
        }


        private void uiAccount_Load(object sender, EventArgs e)
        {
            this.FormClosing += (s, e) =>
            {
                _encrypt = null;
            };

            lblEmail.Text = _user.Email;
            lblUsername.Text = _user.Email.Replace("@jwlmt.com", "");
            lblUser.Text = _user.Role;
            videoPanel.BackgroundImage = Resources.icons8_male_user_96;
        }

        private void bntSettings_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(uiSettings.Instance());
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            MainHost.Instance().loggedInUser = null;
            File.Delete(MainHost.Instance().UserFile);
            uiLILOAccountLogin.SetInstance(null);
            MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));
        }

        private void sPanel11_Paint(object sender, PaintEventArgs e)
        {
        }

        /*
        #region GoogleLogin
        private void btn_LoginGoogle_Click(object sender, EventArgs e)
        {
            var url = AuthResponse.GetAutenticationURI(clientId, redirectURI).ToString();
            Process.Start(url);
            Thread.Sleep(1000);
            DisplayMemoryUsageInTitleAsync();
        }

        public const string clientId = "662959790489-sqt6ja2lqj5hnd4o7g7ki4jg7j0okvl5.apps.googleusercontent.com";
        public const string clientSecret = "pJFA5xdGQ-MbRdEniXIseRH-";
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";
        public bool flag = true;

        public AuthResponse access;


        private void GetProfile(string approveCode)
        {
            access = AuthResponse.Exchange(approveCode, clientId, clientSecret, redirectURI);
            var url = $"https://www.googleapis.com/oauth2/v3/userinfo?access_token={access.Access_token}";
            var wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.AcceptCharset, "utf-8");
            wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; …) Gecko/20100101 Firefox/55.0");
            wc.Encoding = Encoding.UTF8;
            var jsonProfile = wc.DownloadString(url);
            var frm = new FrmProfile(jsonProfile);
            frm.Show();
            this.Hide();
        }

        private void DisplayMemoryUsageInTitleAsync()
        {
            BackgroundWorker wrkr = new BackgroundWorker();
            wrkr.WorkerReportsProgress = true;

            wrkr.DoWork += (object sender, DoWorkEventArgs e) => {

                bool result;
                while (result = GetAppoveCodeGoogle())
                {
                    wrkr.ReportProgress(0, result);
                    Thread.Sleep(100);
                }

                wrkr.Dispose();
                Process[] procsChrome = Process.GetProcessesByName("chrome");
                foreach (Process chrome in procsChrome)
                {
                    if (chrome.MainWindowHandle == IntPtr.Zero)
                        continue;

                    AutomationElement element = AutomationElement.FromHandle(chrome.MainWindowHandle);
                    if (element != null)
                    {
                        Condition conditions = new AndCondition(
                       new PropertyCondition(AutomationElement.ProcessIdProperty, chrome.Id),
                       new PropertyCondition(AutomationElement.IsControlElementProperty, true),
                       new PropertyCondition(AutomationElement.IsContentElementProperty, true),
                       new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

                        AutomationElement elementx = element.FindFirst(TreeScope.Descendants, conditions);
                        var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                        if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                        {
                            ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).SetValue("https://laptrinhvb.net");
                            ChromeWrapper chromes = new ChromeWrapper();

                            chromes.SendKey((char)13, chrome);//enter
                            var arr = url.Split('&');
                            var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 1].Replace("approvalCode=", ""));
                            this.BeginInvoke(new Action(() =>
                            {
                                GetProfile(approvalCode);
                            }));
                        }
                    }
                }
                wrkr.Dispose();
            };
            wrkr.RunWorkerAsync();
        }

        public bool GetAppoveCodeGoogle()
        {
            Process[] procsChrome = Process.GetProcessesByName("chrome");
            foreach (Process chrome in procsChrome)
            {
                if (chrome.MainWindowHandle == IntPtr.Zero)
                    continue;

                AutomationElement element = AutomationElement.FromHandle(chrome.MainWindowHandle);
                if (element != null)
                {
                    Condition conditions = new AndCondition(
                   new PropertyCondition(AutomationElement.ProcessIdProperty, chrome.Id),
                   new PropertyCondition(AutomationElement.IsControlElementProperty, true),
                   new PropertyCondition(AutomationElement.IsContentElementProperty, true),
                   new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

                    AutomationElement elementx = element.FindFirst(TreeScope.Descendants, conditions);
                    var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                    if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                    {
                        var arr = url.Split('&');
                        var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 1].Replace("approvalCode=", ""));
                        return false;
                    }

                }


            }
            return true;
        }
        #endregion
        */
    }
}
