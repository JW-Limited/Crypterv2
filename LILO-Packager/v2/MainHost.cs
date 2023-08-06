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

namespace LILO_Packager.v2;
public partial class MainHost : System.Windows.Forms.Form
{
    private static MainHost instance;
    private static object _lock = new object();

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
    public ObservableCollection<PluginEntry> plugins { get; set; } = new ObservableCollection<PluginEntry>();
    private PluginManager manager = null;

    private MainHost()
    {
        InitializeComponent();
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

    private void MainHost_Load(object sender, EventArgs e)
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

        this.BackColor = SystemColors.ButtonFace;

        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));

        if (config.Default.allowedPlugins)
        {

            manager = new PluginManager(".\\plugins");

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

                MessageBox.Show("We found Plugins and loaded them:\n\n" + stringBuilder.ToString(),"PluginManager");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

    public enum ChildrenUse
    {
        Auth,
        WebView,
        NormalForm
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

        /*

        currentOpenedApp.FormClosing += (sender, e) =>
        {
            this.IsMdiContainer = false;
            this.BackColor = Color.White;
            pnlChild.Dock = DockStyle.None;
            pnlChild.Size = new Size(1, 1);
        };*/
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080/help/")));
    }

    private void bntOpen_Click(object sender, EventArgs e)
    {
        PluginEntry encryptionLibrary = null;

        foreach(var plugin in plugins)
        {
            if(PluginID.IDtoString(plugin.ID) == PluginID.IDtoString(PluginID.GetID("enc", "lbl", "lvl01")))
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
                encryptionLibrary.form.Show();

                OpenInApp(v2.Forms.uiEncryt.Instance());
            }


        }
        else
        {
            MessageBox.Show($"Please Install the necessary Librarys to such operations.\n\nMissing EncryptionModelLibrary.{encryptionLibrary.ID.ToString() + PluginID.GetID("enc", "lbl", "lvl01").ToString()}","PluginManager", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiDecrypt.Instance());
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
        OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080/work/")));
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {
        OpenInApp(v2.Forms.uiSettings.Instance());
    }
}
