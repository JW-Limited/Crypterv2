namespace LILO_Packager.v2.Forms
{
    partial class uiPluginStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPluginStore));
            lblText = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            sPanel1 = new Sipaa.Framework.SPanel();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            plainPlugin = new Controls.DynamicPluginListItem();
            encryptenPlugin = new Controls.DynamicPluginListItem();
            label1 = new Label();
            pnlNetworkError = new Sipaa.Framework.SPanel();
            lblMes = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblExc = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            sPanel2.SuspendLayout();
            sPanel1.SuspendLayout();
            pnlNetworkError.SuspendLayout();
            imgImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            resources.ApplyResources(lblText, "lblText");
            lblText.ForeColor = Color.DimGray;
            lblText.Name = "lblText";
            // 
            // sPanel2
            // 
            resources.ApplyResources(sPanel2, "sPanel2");
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(lblText);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.ForeColor = Color.White;
            sPanel2.Name = "sPanel2";
            // 
            // bntCancel
            // 
            resources.ApplyResources(bntCancel, "bntCancel");
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 20;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.White;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Name = "bntCancel";
            bntCancel.Click += bntCancel_Click;
            // 
            // sPanel1
            // 
            resources.ApplyResources(sPanel1, "sPanel1");
            sPanel1.BackColor = Color.White;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 2;
            sPanel1.Controls.Add(progress);
            sPanel1.Controls.Add(plainPlugin);
            sPanel1.Controls.Add(encryptenPlugin);
            sPanel1.ForeColor = Color.White;
            sPanel1.Name = "sPanel1";
            // 
            // progress
            // 
            resources.ApplyResources(progress, "progress");
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 20;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            progress.Name = "progress";
            progress.ProgressColor = Color.White;
            progress.ProgressColor2 = Color.SlateGray;
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // plainPlugin
            // 
            resources.ApplyResources(plainPlugin, "plainPlugin");
            plainPlugin.BackColor = Color.White;
            plainPlugin.BorderColor = Color.Gainsboro;
            plainPlugin.BorderRadius = 20;
            plainPlugin.BorderThickness = 2;
            plainPlugin.ButtonText = "Download";
            plainPlugin.ButtonVisible = true;
            plainPlugin.ControlBackgroundColor = Color.White;
            plainPlugin.DataContext = null;
            plainPlugin.DownloadButtonBackColor = Color.White;
            plainPlugin.DownloadButtonForeColor = Color.Black;
            plainPlugin.Name = "plainPlugin";
            plainPlugin.Plugin_State = v2.Controls.DynamicPluginListItem.PluginState.Available;
            plainPlugin.PluginDescription = "Can view plainbased files.";
            plainPlugin.PluginDescriptionForeColor = Color.DimGray;
            plainPlugin.PluginIcon = Properties.Resources.plainLib;
            plainPlugin.PluginName = "Textpreview";
            plainPlugin.PluginNameForeColor = Color.Black;
            plainPlugin.PluginVersion = "0.2.12-alpha";
            plainPlugin.PluginVersionForeColor = Color.DarkGray;
            plainPlugin.ClickedDownload += plainPlugin_ClickedDownload;
            // 
            // encryptenPlugin
            // 
            resources.ApplyResources(encryptenPlugin, "encryptenPlugin");
            encryptenPlugin.BackColor = Color.White;
            encryptenPlugin.BorderColor = Color.Gainsboro;
            encryptenPlugin.BorderRadius = 20;
            encryptenPlugin.BorderThickness = 2;
            encryptenPlugin.ButtonText = "Download";
            encryptenPlugin.ButtonVisible = true;
            encryptenPlugin.ControlBackgroundColor = Color.White;
            encryptenPlugin.DataContext = null;
            encryptenPlugin.DownloadButtonBackColor = Color.White;
            encryptenPlugin.DownloadButtonForeColor = Color.Black;
            encryptenPlugin.Name = "encryptenPlugin";
            encryptenPlugin.Plugin_State = v2.Controls.DynamicPluginListItem.PluginState.Available;
            encryptenPlugin.PluginDescription = "Installs encryption Librarys.";
            encryptenPlugin.PluginDescriptionForeColor = Color.DimGray;
            encryptenPlugin.PluginIcon = Properties.Resources.logo_sync;
            encryptenPlugin.PluginName = "EncLib Installer";
            encryptenPlugin.PluginNameForeColor = Color.Black;
            encryptenPlugin.PluginVersion = "0.1.11-alpha";
            encryptenPlugin.PluginVersionForeColor = Color.DarkGray;
            encryptenPlugin.ClickedDownload += encryptenPlugin_ClickedDownload;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Name = "label1";
            // 
            // pnlNetworkError
            // 
            resources.ApplyResources(pnlNetworkError, "pnlNetworkError");
            pnlNetworkError.BackColor = Color.White;
            pnlNetworkError.BorderColor = Color.Black;
            pnlNetworkError.BorderRadius = 0;
            pnlNetworkError.BorderSize = 0;
            pnlNetworkError.Controls.Add(lblMes);
            pnlNetworkError.Controls.Add(guna2Button1);
            pnlNetworkError.Controls.Add(lblExc);
            pnlNetworkError.Controls.Add(imgImage);
            pnlNetworkError.ForeColor = Color.White;
            pnlNetworkError.Name = "pnlNetworkError";
            // 
            // lblMes
            // 
            resources.ApplyResources(lblMes, "lblMes");
            lblMes.AutoEllipsis = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.ForeColor = Color.Gray;
            lblMes.Name = "lblMes";
            // 
            // guna2Button1
            // 
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // lblExc
            // 
            resources.ApplyResources(lblExc, "lblExc");
            lblExc.AutoEllipsis = true;
            lblExc.BackColor = Color.Transparent;
            lblExc.ForeColor = Color.DimGray;
            lblExc.Name = "lblExc";
            // 
            // imgImage
            // 
            resources.ApplyResources(imgImage, "imgImage");
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.image_removebg_preview__2_;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 20;
            imgImage.Controls.Add(guna2Panel2);
            imgImage.FillColor = Color.Transparent;
            imgImage.Name = "imgImage";
            // 
            // guna2Panel2
            // 
            resources.ApplyResources(guna2Panel2, "guna2Panel2");
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BackgroundImage = Properties.Resources.Close;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Name = "guna2Panel2";
            // 
            // uiPluginStore
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlNetworkError);
            Controls.Add(label1);
            Controls.Add(sPanel1);
            Controls.Add(sPanel2);
            Name = "uiPluginStore";
            Load += uiPluginStore_Load;
            sPanel2.ResumeLayout(false);
            sPanel1.ResumeLayout(false);
            pnlNetworkError.ResumeLayout(false);
            imgImage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblText;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Sipaa.Framework.SPanel sPanel1;
        private Label label1;
        private Controls.DynamicPluginListItem dynamicPluginListItem3;
        private Controls.DynamicPluginListItem plainPlugin;
        private Controls.DynamicPluginListItem encryptenPlugin;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private Sipaa.Framework.SPanel pnlNetworkError;
        private Label lblExc;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lblMes;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}