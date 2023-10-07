using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.LILO;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms;
public partial class uiSettings : Form
{
    private static uiSettings _encrypt;
    private User _user;
    public Shared.FileOperations sharedFile = new();
    private static object _lock = new object();
    public static uiSettings Instance(User user)
    {
        lock (_lock)
        {
            if (_encrypt is null || _encrypt.IsDisposed)
            {
                _encrypt = new uiSettings(user);
            }

            return _encrypt;
        }
    }



    private uiSettings(User user)
    {
        InitializeComponent();

        _user = user;

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = true;
            this.Hide();
        };
    }

    private void uiSettings_Load(object sender, EventArgs e)
    {
        chbPlugins.Checked = FeatureManager.IsFeatureEnabled(FeatureFlags.PluginSupport);
        chbUpdates.Checked = config.Default.autoUpdates;
        chbStream.Checked = FeatureManager.IsFeatureEnabled(FeatureFlags.SecuredContainerStreaming);
        chbLibrarys.Checked = FeatureManager.IsFeatureEnabled(FeatureFlags.ThirdPartyPluginSupport);
        chbDeleteFile.Checked = config.Default.deleteFile;
        chbDebug.Checked = config.Default.debugMode;

        Thread.Sleep(300);
    }

    private void label5_Click(object sender, EventArgs e)
    {
        MainHost.Instance().OpenInApp(v2.Forms.uiAccount.Instance(_user));
    }

    private void chbDeleteFile_CheckedChanged(object sender, EventArgs e)
    {
        config.Default.deleteFile = chbDeleteFile.Checked;
        config.Default.Save();
    }

    private async void chbStream_CheckedChanged(object sender, EventArgs e)
    {
        await FeatureManager.ToggleFeatureAsync(FeatureFlags.SecuredContainerStreaming);
    }

    private void chbDebug_CheckedChanged(object sender, EventArgs e)
    {
        config.Default.debugMode = chbDebug.Checked;
        config.Default.Save();
    }

    private void chbUpdates_CheckedChanged(object sender, EventArgs e)
    {
        config.Default.autoUpdates = chbUpdates.Checked;
        config.Default.Save();
    }

    private async void chbLibrarys_CheckedChanged(object sender, EventArgs e)
    {
        await FeatureManager.ToggleFeatureAsync(FeatureFlags.ThirdPartyPluginSupport);
    }

    private async void chbPlugins_CheckedChanged(object sender, EventArgs e)
    {
        await FeatureManager.ToggleFeatureAsync(FeatureFlags.PluginSupport);
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        MainHost.Instance().OpenInApp(new uiFeatureNullException("AccountDenied", "This Feature is not availlabel."));
    }

    private void bntSrvlocal(object sender, EventArgs e)
    {
        MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080/config/")));
    }
}
