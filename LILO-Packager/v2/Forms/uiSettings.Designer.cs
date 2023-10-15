namespace LILO_Packager.v2.Forms;

partial class uiSettings
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
        sPanel1 = new Sipaa.Framework.SPanel();
        lblText = new Label();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        label5 = new Label();
        lblProductName = new Label();
        label4 = new Label();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        chbDeleteFile = new Controls.DynamicToggleButton();
        guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
        chbStream = new Controls.DynamicToggleButton();
        label13 = new Label();
        label14 = new Label();
        guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
        chbDebug = new Controls.DynamicToggleButton();
        label6 = new Label();
        label16 = new Label();
        label17 = new Label();
        guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
        chbUpdates = new Controls.DynamicToggleButton();
        label8 = new Label();
        label9 = new Label();
        guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
        chbLibrarys = new Controls.DynamicToggleButton();
        label11 = new Label();
        label12 = new Label();
        guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
        chbPlugins = new Controls.DynamicToggleButton();
        label20 = new Label();
        label18 = new Label();
        label19 = new Label();
        label21 = new Label();
        sPanel11 = new Sipaa.Framework.SPanel();
        guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
        dynamicToggleButton1 = new Controls.DynamicToggleButton();
        label42 = new Label();
        label23 = new Label();
        label24 = new Label();
        guna2Panel21 = new Guna.UI2.WinForms.Guna2Panel();
        label35 = new Label();
        label36 = new Label();
        guna2Panel22 = new Guna.UI2.WinForms.Guna2Panel();
        label37 = new Label();
        sToggleButton5 = new Sipaa.Framework.SToggleButton();
        guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
        label39 = new Label();
        label40 = new Label();
        guna2Panel24 = new Guna.UI2.WinForms.Guna2Panel();
        label41 = new Label();
        sToggleButton6 = new Sipaa.Framework.SToggleButton();
        sPanel1.SuspendLayout();
        guna2Panel1.SuspendLayout();
        guna2Panel5.SuspendLayout();
        guna2Panel6.SuspendLayout();
        guna2Panel8.SuspendLayout();
        guna2Panel10.SuspendLayout();
        guna2Panel12.SuspendLayout();
        guna2Panel7.SuspendLayout();
        guna2Panel21.SuspendLayout();
        guna2Panel22.SuspendLayout();
        guna2Panel23.SuspendLayout();
        guna2Panel24.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = Properties.Resources.Royal_Blue;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(lblText);
        sPanel1.Controls.Add(guna2Button2);
        sPanel1.Controls.Add(guna2Button5);
        sPanel1.Controls.Add(label5);
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(24, 32);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(974, 88);
        sPanel1.TabIndex = 12;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        lblText.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblText.ForeColor = Color.White;
        lblText.Location = new Point(88, 0);
        lblText.Margin = new Padding(4, 0, 4, 0);
        lblText.Name = "lblText";
        lblText.Size = new Size(144, 88);
        lblText.TabIndex = 1;
        lblText.Text = "Settings";
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // guna2Button2
        // 
        guna2Button2.Animated = true;
        guna2Button2.BackColor = Color.Transparent;
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 20;
        guna2Button2.BorderThickness = 2;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Image = Properties.Resources.icons8_back_96;
        guna2Button2.ImageSize = new Size(35, 35);
        guna2Button2.Location = new Point(16, 16);
        guna2Button2.Margin = new Padding(2);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.Size = new Size(72, 58);
        guna2Button2.TabIndex = 17;
        guna2Button2.Click += label5_Click;
        // 
        // guna2Button5
        // 
        guna2Button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button5.Animated = true;
        guna2Button5.BackColor = Color.Transparent;
        guna2Button5.BorderColor = Color.Gainsboro;
        guna2Button5.BorderRadius = 20;
        guna2Button5.BorderThickness = 2;
        guna2Button5.DisabledState.BorderColor = Color.DarkGray;
        guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button5.FillColor = Color.Transparent;
        guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button5.ForeColor = Color.White;
        guna2Button5.Location = new Point(814, 16);
        guna2Button5.Margin = new Padding(2);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.Size = new Size(144, 58);
        guna2Button5.TabIndex = 17;
        guna2Button5.Text = "Passwords";
        guna2Button5.Click += guna2Button5_Click;
        // 
        // label5
        // 
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
        label5.ForeColor = Color.White;
        label5.Location = new Point(0, 0);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(112, 80);
        label5.TabIndex = 1;
        label5.Text = "...";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        label5.Click += label5_Click;
        // 
        // lblProductName
        // 
        lblProductName.BackColor = Color.Transparent;
        lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblProductName.Location = new Point(24, 20);
        lblProductName.Margin = new Padding(2, 0, 2, 0);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(176, 39);
        lblProductName.TabIndex = 15;
        lblProductName.Text = "Delete File";
        lblProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label4.BackColor = Color.Transparent;
        label4.ForeColor = Color.DimGray;
        label4.Location = new Point(24, 68);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(248, 64);
        label4.TabIndex = 14;
        label4.Text = "Deletes the original file after Encryption";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel1
        // 
        guna2Panel1.Anchor = AnchorStyles.Top;
        guna2Panel1.BorderColor = Color.Gainsboro;
        guna2Panel1.BorderRadius = 15;
        guna2Panel1.BorderThickness = 2;
        guna2Panel1.Controls.Add(chbDeleteFile);
        guna2Panel1.Controls.Add(label4);
        guna2Panel1.Controls.Add(lblProductName);
        guna2Panel1.FillColor = Color.White;
        guna2Panel1.Location = new Point(31, 192);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(296, 224);
        guna2Panel1.TabIndex = 16;
        // 
        // chbDeleteFile
        // 
        chbDeleteFile.BorderColor = Color.Gainsboro;
        chbDeleteFile.BorderRadius = 15;
        chbDeleteFile.Checked = false;
        chbDeleteFile.CheckedColor = Color.FromArgb(94, 148, 255);
        chbDeleteFile.CheckedText = "Enabled";
        chbDeleteFile.DisabledText = "Not Changable";
        chbDeleteFile.EnabledState = true;
        chbDeleteFile.Location = new Point(16, 152);
        chbDeleteFile.Name = "chbDeleteFile";
        chbDeleteFile.Size = new Size(264, 56);
        chbDeleteFile.TabIndex = 16;
        chbDeleteFile.UnCheckedText = "Disabled";
        chbDeleteFile.Clicked += chbDeleteFile_CheckedChanged;
        // 
        // guna2Panel5
        // 
        guna2Panel5.Anchor = AnchorStyles.Top;
        guna2Panel5.BorderColor = Color.Gainsboro;
        guna2Panel5.BorderRadius = 15;
        guna2Panel5.BorderThickness = 2;
        guna2Panel5.Controls.Add(chbStream);
        guna2Panel5.Controls.Add(label13);
        guna2Panel5.Controls.Add(label14);
        guna2Panel5.FillColor = Color.White;
        guna2Panel5.Location = new Point(359, 192);
        guna2Panel5.Margin = new Padding(2);
        guna2Panel5.Name = "guna2Panel5";
        guna2Panel5.Size = new Size(296, 224);
        guna2Panel5.TabIndex = 16;
        // 
        // chbStream
        // 
        chbStream.BorderColor = Color.Gainsboro;
        chbStream.BorderRadius = 15;
        chbStream.Checked = false;
        chbStream.CheckedColor = Color.FromArgb(94, 148, 255);
        chbStream.CheckedText = "Enabled";
        chbStream.DisabledText = "Not Changable";
        chbStream.EnabledState = true;
        chbStream.Location = new Point(16, 152);
        chbStream.Name = "chbStream";
        chbStream.Size = new Size(264, 56);
        chbStream.TabIndex = 16;
        chbStream.UnCheckedText = "Disabled";
        chbStream.Clicked += chbStream_CheckedChanged;
        // 
        // label13
        // 
        label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label13.BackColor = Color.Transparent;
        label13.ForeColor = Color.DimGray;
        label13.Location = new Point(24, 68);
        label13.Margin = new Padding(2, 0, 2, 0);
        label13.Name = "label13";
        label13.Size = new Size(248, 64);
        label13.TabIndex = 14;
        label13.Text = "Enables the secured stream container";
        label13.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label14
        // 
        label14.BackColor = Color.Transparent;
        label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label14.Location = new Point(24, 20);
        label14.Margin = new Padding(2, 0, 2, 0);
        label14.Name = "label14";
        label14.Size = new Size(176, 39);
        label14.TabIndex = 15;
        label14.Text = "Stream";
        label14.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel6
        // 
        guna2Panel6.Anchor = AnchorStyles.Top;
        guna2Panel6.BorderColor = Color.Gainsboro;
        guna2Panel6.BorderRadius = 15;
        guna2Panel6.BorderThickness = 2;
        guna2Panel6.Controls.Add(chbDebug);
        guna2Panel6.Controls.Add(label6);
        guna2Panel6.Controls.Add(label16);
        guna2Panel6.Controls.Add(label17);
        guna2Panel6.FillColor = Color.White;
        guna2Panel6.Location = new Point(686, 192);
        guna2Panel6.Margin = new Padding(2);
        guna2Panel6.Name = "guna2Panel6";
        guna2Panel6.Size = new Size(296, 224);
        guna2Panel6.TabIndex = 16;
        // 
        // chbDebug
        // 
        chbDebug.BorderColor = Color.Gainsboro;
        chbDebug.BorderRadius = 15;
        chbDebug.Checked = false;
        chbDebug.CheckedColor = Color.FromArgb(94, 148, 255);
        chbDebug.CheckedText = "Enabled";
        chbDebug.DisabledText = "Not Changable";
        chbDebug.EnabledState = true;
        chbDebug.Location = new Point(17, 152);
        chbDebug.Name = "chbDebug";
        chbDebug.Size = new Size(264, 56);
        chbDebug.TabIndex = 16;
        chbDebug.UnCheckedText = "Disabled";
        chbDebug.Clicked += chbDebug_CheckedChanged;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label6.BackColor = Color.Transparent;
        label6.Location = new Point(112, 16);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(152, 48);
        label6.TabIndex = 14;
        label6.Text = "(Restart)";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label16
        // 
        label16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label16.BackColor = Color.Transparent;
        label16.ForeColor = Color.DimGray;
        label16.Location = new Point(24, 68);
        label16.Margin = new Padding(2, 0, 2, 0);
        label16.Name = "label16";
        label16.Size = new Size(248, 64);
        label16.TabIndex = 14;
        label16.Text = "Enables the Debug-Mode and opens a dev port.";
        label16.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label17
        // 
        label17.BackColor = Color.Transparent;
        label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label17.Location = new Point(24, 20);
        label17.Margin = new Padding(2, 0, 2, 0);
        label17.Name = "label17";
        label17.Size = new Size(176, 39);
        label17.TabIndex = 15;
        label17.Text = "Debug";
        label17.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel8
        // 
        guna2Panel8.Anchor = AnchorStyles.Top;
        guna2Panel8.BorderColor = Color.Gainsboro;
        guna2Panel8.BorderRadius = 15;
        guna2Panel8.BorderThickness = 2;
        guna2Panel8.Controls.Add(chbUpdates);
        guna2Panel8.Controls.Add(label8);
        guna2Panel8.Controls.Add(label9);
        guna2Panel8.FillColor = Color.White;
        guna2Panel8.Location = new Point(31, 440);
        guna2Panel8.Margin = new Padding(2);
        guna2Panel8.Name = "guna2Panel8";
        guna2Panel8.Size = new Size(296, 224);
        guna2Panel8.TabIndex = 16;
        // 
        // chbUpdates
        // 
        chbUpdates.BorderColor = Color.Gainsboro;
        chbUpdates.BorderRadius = 15;
        chbUpdates.Checked = false;
        chbUpdates.CheckedColor = Color.FromArgb(94, 148, 255);
        chbUpdates.CheckedText = "Enabled";
        chbUpdates.DisabledText = "Not Changable";
        chbUpdates.EnabledState = true;
        chbUpdates.Location = new Point(16, 152);
        chbUpdates.Name = "chbUpdates";
        chbUpdates.Size = new Size(264, 56);
        chbUpdates.TabIndex = 16;
        chbUpdates.UnCheckedText = "Disabled";
        chbUpdates.Clicked += chbUpdates_CheckedChanged;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label8.BackColor = Color.Transparent;
        label8.ForeColor = Color.DimGray;
        label8.Location = new Point(24, 68);
        label8.Margin = new Padding(2, 0, 2, 0);
        label8.Name = "label8";
        label8.Size = new Size(248, 64);
        label8.TabIndex = 14;
        label8.Text = "Automaticly Check for newer Versions";
        label8.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.BackColor = Color.Transparent;
        label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label9.Location = new Point(24, 20);
        label9.Margin = new Padding(2, 0, 2, 0);
        label9.Name = "label9";
        label9.Size = new Size(176, 39);
        label9.TabIndex = 15;
        label9.Text = "Updates";
        label9.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel10
        // 
        guna2Panel10.Anchor = AnchorStyles.Top;
        guna2Panel10.BorderColor = Color.Gainsboro;
        guna2Panel10.BorderRadius = 15;
        guna2Panel10.BorderThickness = 2;
        guna2Panel10.Controls.Add(chbLibrarys);
        guna2Panel10.Controls.Add(label11);
        guna2Panel10.Controls.Add(label12);
        guna2Panel10.FillColor = Color.White;
        guna2Panel10.Location = new Point(359, 440);
        guna2Panel10.Margin = new Padding(2);
        guna2Panel10.Name = "guna2Panel10";
        guna2Panel10.Size = new Size(296, 224);
        guna2Panel10.TabIndex = 16;
        // 
        // chbLibrarys
        // 
        chbLibrarys.BorderColor = Color.Gainsboro;
        chbLibrarys.BorderRadius = 15;
        chbLibrarys.Checked = false;
        chbLibrarys.CheckedColor = Color.FromArgb(94, 148, 255);
        chbLibrarys.CheckedText = "Enabled";
        chbLibrarys.DisabledText = "Not Changable";
        chbLibrarys.EnabledState = true;
        chbLibrarys.Location = new Point(16, 152);
        chbLibrarys.Name = "chbLibrarys";
        chbLibrarys.Size = new Size(264, 56);
        chbLibrarys.TabIndex = 16;
        chbLibrarys.UnCheckedText = "Disabled";
        chbLibrarys.Clicked += chbLibrarys_CheckedChanged;
        // 
        // label11
        // 
        label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label11.BackColor = Color.Transparent;
        label11.ForeColor = Color.DimGray;
        label11.Location = new Point(24, 68);
        label11.Margin = new Padding(2, 0, 2, 0);
        label11.Name = "label11";
        label11.Size = new Size(248, 68);
        label11.TabIndex = 14;
        label11.Text = "Enable feature enhancements based off on external librarys";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label12
        // 
        label12.BackColor = Color.Transparent;
        label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label12.Location = new Point(24, 20);
        label12.Margin = new Padding(2, 0, 2, 0);
        label12.Name = "label12";
        label12.Size = new Size(176, 39);
        label12.TabIndex = 15;
        label12.Text = "Librarys";
        label12.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel12
        // 
        guna2Panel12.Anchor = AnchorStyles.Top;
        guna2Panel12.BorderColor = Color.Gainsboro;
        guna2Panel12.BorderRadius = 15;
        guna2Panel12.BorderThickness = 2;
        guna2Panel12.Controls.Add(chbPlugins);
        guna2Panel12.Controls.Add(label20);
        guna2Panel12.Controls.Add(label18);
        guna2Panel12.Controls.Add(label19);
        guna2Panel12.FillColor = Color.White;
        guna2Panel12.Location = new Point(688, 440);
        guna2Panel12.Margin = new Padding(2);
        guna2Panel12.Name = "guna2Panel12";
        guna2Panel12.Size = new Size(296, 224);
        guna2Panel12.TabIndex = 16;
        // 
        // chbPlugins
        // 
        chbPlugins.BorderColor = Color.Gainsboro;
        chbPlugins.BorderRadius = 15;
        chbPlugins.Checked = true;
        chbPlugins.CheckedColor = Color.IndianRed;
        chbPlugins.CheckedText = "Enabled";
        chbPlugins.DisabledText = "Not Changable";
        chbPlugins.EnabledState = false;
        chbPlugins.Location = new Point(16, 152);
        chbPlugins.Name = "chbPlugins";
        chbPlugins.Size = new Size(264, 56);
        chbPlugins.TabIndex = 16;
        chbPlugins.UnCheckedText = "Disabled";
        // 
        // label20
        // 
        label20.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label20.BackColor = Color.Transparent;
        label20.ForeColor = SystemColors.ControlDark;
        label20.Location = new Point(120, 16);
        label20.Margin = new Padding(2, 0, 2, 0);
        label20.Name = "label20";
        label20.Size = new Size(152, 48);
        label20.TabIndex = 14;
        label20.Text = "(Required)";
        label20.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label18
        // 
        label18.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label18.BackColor = Color.Transparent;
        label18.ForeColor = Color.DimGray;
        label18.Location = new Point(24, 68);
        label18.Margin = new Padding(2, 0, 2, 0);
        label18.Name = "label18";
        label18.Size = new Size(248, 64);
        label18.TabIndex = 14;
        label18.Text = "Enables the support and the Manager\r\n";
        label18.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label19
        // 
        label19.BackColor = Color.Transparent;
        label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label19.Location = new Point(24, 20);
        label19.Margin = new Padding(2, 0, 2, 0);
        label19.Name = "label19";
        label19.Size = new Size(176, 39);
        label19.TabIndex = 15;
        label19.Text = "Plugins";
        label19.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label21
        // 
        label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label21.BackColor = Color.Transparent;
        label21.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
        label21.ForeColor = Color.Gray;
        label21.Location = new Point(896, 1079);
        label21.Margin = new Padding(4, 0, 4, 0);
        label21.Name = "label21";
        label21.Size = new Size(112, 32);
        label21.TabIndex = 20;
        label21.Text = "powered by ";
        label21.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // sPanel11
        // 
        sPanel11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        sPanel11.BackColor = Color.White;
        sPanel11.BackgroundImage = Properties.Resources.Screenshot_2023_08_26_190917;
        sPanel11.BackgroundImageLayout = ImageLayout.Zoom;
        sPanel11.BorderColor = Color.Black;
        sPanel11.BorderRadius = 0;
        sPanel11.BorderSize = 0;
        sPanel11.ForeColor = Color.White;
        sPanel11.Location = new Point(896, 1111);
        sPanel11.Margin = new Padding(4);
        sPanel11.Name = "sPanel11";
        sPanel11.Size = new Size(88, 32);
        sPanel11.TabIndex = 19;
        // 
        // guna2Panel7
        // 
        guna2Panel7.Anchor = AnchorStyles.Top;
        guna2Panel7.BorderColor = Color.Gainsboro;
        guna2Panel7.BorderRadius = 15;
        guna2Panel7.BorderThickness = 2;
        guna2Panel7.Controls.Add(dynamicToggleButton1);
        guna2Panel7.Controls.Add(label42);
        guna2Panel7.Controls.Add(label23);
        guna2Panel7.Controls.Add(label24);
        guna2Panel7.FillColor = Color.White;
        guna2Panel7.Location = new Point(32, 688);
        guna2Panel7.Margin = new Padding(2);
        guna2Panel7.Name = "guna2Panel7";
        guna2Panel7.Size = new Size(296, 224);
        guna2Panel7.TabIndex = 16;
        // 
        // dynamicToggleButton1
        // 
        dynamicToggleButton1.BorderColor = Color.Gainsboro;
        dynamicToggleButton1.BorderRadius = 15;
        dynamicToggleButton1.Checked = false;
        dynamicToggleButton1.CheckedColor = Color.FromArgb(94, 148, 255);
        dynamicToggleButton1.CheckedText = "Enabled";
        dynamicToggleButton1.DisabledText = "Not Changable";
        dynamicToggleButton1.EnabledState = false;
        dynamicToggleButton1.Location = new Point(16, 152);
        dynamicToggleButton1.Name = "dynamicToggleButton1";
        dynamicToggleButton1.Size = new Size(256, 56);
        dynamicToggleButton1.TabIndex = 16;
        dynamicToggleButton1.UnCheckedText = "Disabled";
        // 
        // label42
        // 
        label42.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label42.BackColor = Color.Transparent;
        label42.ForeColor = SystemColors.ControlDark;
        label42.Location = new Point(120, 16);
        label42.Margin = new Padding(2, 0, 2, 0);
        label42.Name = "label42";
        label42.Size = new Size(152, 48);
        label42.TabIndex = 14;
        label42.Text = "(Still Unstable)";
        label42.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label23
        // 
        label23.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label23.BackColor = Color.Transparent;
        label23.ForeColor = Color.DimGray;
        label23.Location = new Point(24, 68);
        label23.Margin = new Padding(2, 0, 2, 0);
        label23.Name = "label23";
        label23.Size = new Size(232, 68);
        label23.TabIndex = 14;
        label23.Text = "Enable OpenGL and DirectX rendering.";
        label23.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label24
        // 
        label24.BackColor = Color.Transparent;
        label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label24.Location = new Point(24, 20);
        label24.Margin = new Padding(2, 0, 2, 0);
        label24.Name = "label24";
        label24.Size = new Size(176, 39);
        label24.TabIndex = 15;
        label24.Text = "OpenGl";
        label24.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel21
        // 
        guna2Panel21.Anchor = AnchorStyles.Top;
        guna2Panel21.BorderColor = Color.Gainsboro;
        guna2Panel21.BorderRadius = 15;
        guna2Panel21.BorderThickness = 2;
        guna2Panel21.Controls.Add(label35);
        guna2Panel21.Controls.Add(label36);
        guna2Panel21.Controls.Add(guna2Panel22);
        guna2Panel21.FillColor = Color.White;
        guna2Panel21.Location = new Point(360, 688);
        guna2Panel21.Margin = new Padding(2);
        guna2Panel21.Name = "guna2Panel21";
        guna2Panel21.Size = new Size(296, 224);
        guna2Panel21.TabIndex = 16;
        // 
        // label35
        // 
        label35.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label35.BackColor = Color.Transparent;
        label35.ForeColor = Color.DimGray;
        label35.Location = new Point(24, 68);
        label35.Margin = new Padding(2, 0, 2, 0);
        label35.Name = "label35";
        label35.Size = new Size(248, 64);
        label35.TabIndex = 14;
        label35.Text = "Enables the Operation History recording. ";
        label35.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label36
        // 
        label36.BackColor = Color.Transparent;
        label36.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label36.Location = new Point(24, 20);
        label36.Margin = new Padding(2, 0, 2, 0);
        label36.Name = "label36";
        label36.Size = new Size(176, 39);
        label36.TabIndex = 15;
        label36.Text = "History";
        label36.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel22
        // 
        guna2Panel22.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel22.BorderColor = Color.Gainsboro;
        guna2Panel22.BorderRadius = 15;
        guna2Panel22.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        guna2Panel22.BorderThickness = 2;
        guna2Panel22.Controls.Add(label37);
        guna2Panel22.Controls.Add(sToggleButton5);
        guna2Panel22.FillColor = Color.White;
        guna2Panel22.Location = new Point(16, 152);
        guna2Panel22.Margin = new Padding(2);
        guna2Panel22.Name = "guna2Panel22";
        guna2Panel22.Size = new Size(264, 56);
        guna2Panel22.TabIndex = 16;
        // 
        // label37
        // 
        label37.Anchor = AnchorStyles.Left;
        label37.BackColor = Color.Transparent;
        label37.Location = new Point(16, 8);
        label37.Margin = new Padding(2, 0, 2, 0);
        label37.Name = "label37";
        label37.Size = new Size(96, 40);
        label37.TabIndex = 14;
        label37.Text = "Enabled";
        label37.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // sToggleButton5
        // 
        sToggleButton5.Anchor = AnchorStyles.Right;
        sToggleButton5.AutoSize = true;
        sToggleButton5.BackColor = Color.White;
        sToggleButton5.Checked = true;
        sToggleButton5.CheckState = CheckState.Checked;
        sToggleButton5.Location = new Point(184, 16);
        sToggleButton5.Margin = new Padding(4);
        sToggleButton5.MinimumSize = new Size(56, 28);
        sToggleButton5.Name = "sToggleButton5";
        sToggleButton5.OffBackColor = SystemColors.GrayText;
        sToggleButton5.OffToggleColor = Color.Gainsboro;
        sToggleButton5.OnBackColor = Color.FromArgb(94, 148, 255);
        sToggleButton5.OnToggleColor = Color.WhiteSmoke;
        sToggleButton5.Size = new Size(56, 28);
        sToggleButton5.TabIndex = 13;
        sToggleButton5.UseVisualStyleBackColor = false;
        sToggleButton5.CheckedChanged += chbStream_CheckedChanged;
        // 
        // guna2Panel23
        // 
        guna2Panel23.Anchor = AnchorStyles.Top;
        guna2Panel23.BorderColor = Color.Gainsboro;
        guna2Panel23.BorderRadius = 15;
        guna2Panel23.BorderThickness = 2;
        guna2Panel23.Controls.Add(label39);
        guna2Panel23.Controls.Add(label40);
        guna2Panel23.Controls.Add(guna2Panel24);
        guna2Panel23.FillColor = Color.White;
        guna2Panel23.Location = new Point(687, 688);
        guna2Panel23.Margin = new Padding(2);
        guna2Panel23.Name = "guna2Panel23";
        guna2Panel23.Size = new Size(296, 224);
        guna2Panel23.TabIndex = 16;
        // 
        // label39
        // 
        label39.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label39.BackColor = Color.Transparent;
        label39.ForeColor = Color.DimGray;
        label39.Location = new Point(24, 68);
        label39.Margin = new Padding(2, 0, 2, 0);
        label39.Name = "label39";
        label39.Size = new Size(248, 64);
        label39.TabIndex = 14;
        label39.Text = "Save passwords to a encrypted Database.";
        label39.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label40
        // 
        label40.BackColor = Color.Transparent;
        label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label40.Location = new Point(24, 20);
        label40.Margin = new Padding(2, 0, 2, 0);
        label40.Name = "label40";
        label40.Size = new Size(176, 39);
        label40.TabIndex = 15;
        label40.Text = "Password DB";
        label40.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel24
        // 
        guna2Panel24.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel24.BorderColor = Color.Gainsboro;
        guna2Panel24.BorderRadius = 15;
        guna2Panel24.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        guna2Panel24.BorderThickness = 2;
        guna2Panel24.Controls.Add(label41);
        guna2Panel24.Controls.Add(sToggleButton6);
        guna2Panel24.FillColor = Color.White;
        guna2Panel24.Location = new Point(16, 152);
        guna2Panel24.Margin = new Padding(2);
        guna2Panel24.Name = "guna2Panel24";
        guna2Panel24.Size = new Size(264, 56);
        guna2Panel24.TabIndex = 16;
        // 
        // label41
        // 
        label41.Anchor = AnchorStyles.Left;
        label41.BackColor = Color.Transparent;
        label41.Location = new Point(16, 8);
        label41.Margin = new Padding(2, 0, 2, 0);
        label41.Name = "label41";
        label41.Size = new Size(96, 40);
        label41.TabIndex = 14;
        label41.Text = "Enabled";
        label41.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // sToggleButton6
        // 
        sToggleButton6.Anchor = AnchorStyles.Right;
        sToggleButton6.AutoSize = true;
        sToggleButton6.BackColor = Color.White;
        sToggleButton6.Checked = true;
        sToggleButton6.CheckState = CheckState.Checked;
        sToggleButton6.Location = new Point(184, 16);
        sToggleButton6.Margin = new Padding(4);
        sToggleButton6.MinimumSize = new Size(56, 28);
        sToggleButton6.Name = "sToggleButton6";
        sToggleButton6.OffBackColor = SystemColors.GrayText;
        sToggleButton6.OffToggleColor = Color.Gainsboro;
        sToggleButton6.OnBackColor = Color.FromArgb(94, 148, 255);
        sToggleButton6.OnToggleColor = Color.WhiteSmoke;
        sToggleButton6.Size = new Size(56, 28);
        sToggleButton6.TabIndex = 13;
        sToggleButton6.UseVisualStyleBackColor = false;
        sToggleButton6.CheckedChanged += chbDebug_CheckedChanged;
        // 
        // uiSettings
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1018, 1160);
        Controls.Add(label21);
        Controls.Add(sPanel11);
        Controls.Add(guna2Panel23);
        Controls.Add(guna2Panel6);
        Controls.Add(guna2Panel21);
        Controls.Add(guna2Panel5);
        Controls.Add(guna2Panel12);
        Controls.Add(guna2Panel10);
        Controls.Add(guna2Panel8);
        Controls.Add(guna2Panel7);
        Controls.Add(guna2Panel1);
        Controls.Add(sPanel1);
        Margin = new Padding(2);
        Name = "uiSettings";
        Text = "uiSettings";
        Load += uiSettings_Load;
        sPanel1.ResumeLayout(false);
        guna2Panel1.ResumeLayout(false);
        guna2Panel5.ResumeLayout(false);
        guna2Panel6.ResumeLayout(false);
        guna2Panel8.ResumeLayout(false);
        guna2Panel10.ResumeLayout(false);
        guna2Panel12.ResumeLayout(false);
        guna2Panel7.ResumeLayout(false);
        guna2Panel21.ResumeLayout(false);
        guna2Panel22.ResumeLayout(false);
        guna2Panel22.PerformLayout();
        guna2Panel23.ResumeLayout(false);
        guna2Panel24.ResumeLayout(false);
        guna2Panel24.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Label lblText;
    private Label lblProductName;
    private Label label4;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
    private Label label13;
    private Label label14;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
    private Label label16;
    private Label label17;
    private Label label5;
    private Label label6;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
    private Label label8;
    private Label label9;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
    private Label label11;
    private Label label12;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
    private Label label18;
    private Label label19;
    private Label label20;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Label label21;
    private Sipaa.Framework.SPanel sPanel11;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
    private Label label23;
    private Label label24;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel21;
    private Label label35;
    private Label label36;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel22;
    private Label label37;
    private Sipaa.Framework.SToggleButton sToggleButton5;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
    private Label label39;
    private Label label40;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel24;
    private Label label41;
    private Sipaa.Framework.SToggleButton sToggleButton6;
    private Label label42;
    private Controls.DynamicToggleButton dynamicToggleButton1;
    private Controls.DynamicToggleButton chbPlugins;
    private Controls.DynamicToggleButton chbDeleteFile;
    private Controls.DynamicToggleButton chbStream;
    private Controls.DynamicToggleButton chbDebug;
    private Controls.DynamicToggleButton chbUpdates;
    private Controls.DynamicToggleButton chbLibrarys;
}