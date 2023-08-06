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
        pnlFiles = new Guna.UI2.WinForms.Guna2Panel();
        textBox1 = new TextBox();
        bntCancel = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        windows11Theme1 = new Telerik.WinControls.Themes.Windows11Theme();
        lblProductName = new Label();
        label4 = new Label();
        tgl_diagnostics = new Sipaa.Framework.SToggleButton();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        label1 = new Label();
        guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
        label2 = new Label();
        label3 = new Label();
        sToggleButton1 = new Sipaa.Framework.SToggleButton();
        label5 = new Label();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        label6 = new Label();
        label7 = new Label();
        sToggleButton2 = new Sipaa.Framework.SToggleButton();
        label8 = new Label();
        guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
        label9 = new Label();
        label10 = new Label();
        sToggleButton3 = new Sipaa.Framework.SToggleButton();
        label11 = new Label();
        sPanel1.SuspendLayout();
        pnlFiles.SuspendLayout();
        guna2Panel1.SuspendLayout();
        guna2Panel2.SuspendLayout();
        guna2Panel3.SuspendLayout();
        guna2Panel4.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = Properties.Resources.Aqua_Marine_180degree;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(pnlFiles);
        sPanel1.Controls.Add(bntCancel);
        sPanel1.Controls.Add(lblText);
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(24, 32);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(976, 88);
        sPanel1.TabIndex = 12;
        // 
        // pnlFiles
        // 
        pnlFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pnlFiles.BackColor = Color.Transparent;
        pnlFiles.BorderColor = Color.White;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(textBox1);
        pnlFiles.FillColor = Color.White;
        pnlFiles.Location = new Point(528, 16);
        pnlFiles.Margin = new Padding(2);
        pnlFiles.Name = "pnlFiles";
        pnlFiles.Size = new Size(352, 56);
        pnlFiles.TabIndex = 14;
        // 
        // textBox1
        // 
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        textBox1.Location = new Point(16, 16);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Search here...";
        textBox1.Size = new Size(320, 27);
        textBox1.TabIndex = 0;
        // 
        // bntCancel
        // 
        bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bntCancel.Animated = true;
        bntCancel.BackColor = Color.Transparent;
        bntCancel.BorderColor = Color.Gainsboro;
        bntCancel.BorderRadius = 20;
        bntCancel.BorderThickness = 2;
        bntCancel.DisabledState.BorderColor = Color.DarkGray;
        bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCancel.FillColor = Color.Transparent;
        bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
        bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntCancel.ForeColor = Color.White;
        bntCancel.Location = new Point(896, 16);
        bntCancel.Margin = new Padding(2);
        bntCancel.Name = "bntCancel";
        bntCancel.Size = new Size(64, 58);
        bntCancel.TabIndex = 14;
        bntCancel.Text = "?";
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblText.ForeColor = Color.White;
        lblText.Location = new Point(24, 0);
        lblText.Margin = new Padding(4, 0, 4, 0);
        lblText.Name = "lblText";
        lblText.Size = new Size(144, 88);
        lblText.TabIndex = 1;
        lblText.Text = "Settings";
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblProductName
        // 
        lblProductName.Anchor = AnchorStyles.Left;
        lblProductName.BackColor = Color.Transparent;
        lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblProductName.Location = new Point(24, 24);
        lblProductName.Margin = new Padding(2, 0, 2, 0);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(176, 39);
        lblProductName.TabIndex = 15;
        lblProductName.Text = "Delete File";
        lblProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Left;
        label4.BackColor = Color.Transparent;
        label4.Location = new Point(216, 24);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(338, 39);
        label4.TabIndex = 14;
        label4.Text = "Deletes the original file after Encryption";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tgl_diagnostics
        // 
        tgl_diagnostics.Anchor = AnchorStyles.Right;
        tgl_diagnostics.AutoSize = true;
        tgl_diagnostics.BackColor = Color.White;
        tgl_diagnostics.Checked = true;
        tgl_diagnostics.CheckState = CheckState.Checked;
        tgl_diagnostics.Location = new Point(888, 32);
        tgl_diagnostics.Margin = new Padding(4);
        tgl_diagnostics.MinimumSize = new Size(56, 28);
        tgl_diagnostics.Name = "tgl_diagnostics";
        tgl_diagnostics.OffBackColor = SystemColors.GrayText;
        tgl_diagnostics.OffToggleColor = Color.Gainsboro;
        tgl_diagnostics.OnBackColor = Color.FromArgb(42, 38, 207);
        tgl_diagnostics.OnToggleColor = Color.WhiteSmoke;
        tgl_diagnostics.Size = new Size(56, 28);
        tgl_diagnostics.TabIndex = 13;
        tgl_diagnostics.UseVisualStyleBackColor = false;
        // 
        // guna2Panel1
        // 
        guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel1.BorderColor = SystemColors.ActiveBorder;
        guna2Panel1.BorderRadius = 15;
        guna2Panel1.BorderThickness = 2;
        guna2Panel1.Controls.Add(label1);
        guna2Panel1.Controls.Add(label4);
        guna2Panel1.Controls.Add(tgl_diagnostics);
        guna2Panel1.Controls.Add(lblProductName);
        guna2Panel1.FillColor = Color.White;
        guna2Panel1.Location = new Point(24, 192);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(976, 88);
        guna2Panel1.TabIndex = 16;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.BackColor = Color.Transparent;
        label1.Location = new Point(768, 24);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(96, 39);
        label1.TabIndex = 14;
        label1.Text = "Enabled";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel2
        // 
        guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel2.BorderColor = SystemColors.ActiveBorder;
        guna2Panel2.BorderRadius = 15;
        guna2Panel2.BorderThickness = 2;
        guna2Panel2.Controls.Add(label2);
        guna2Panel2.Controls.Add(label3);
        guna2Panel2.Controls.Add(sToggleButton1);
        guna2Panel2.Controls.Add(label5);
        guna2Panel2.FillColor = Color.White;
        guna2Panel2.Location = new Point(24, 296);
        guna2Panel2.Margin = new Padding(2);
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.Size = new Size(976, 88);
        guna2Panel2.TabIndex = 16;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.BackColor = Color.Transparent;
        label2.Location = new Point(768, 24);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(96, 39);
        label2.TabIndex = 14;
        label2.Text = "Enabled";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Left;
        label3.BackColor = Color.Transparent;
        label3.Location = new Point(216, 24);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(408, 39);
        label3.TabIndex = 14;
        label3.Text = "Shows the process in a form of a Progressbar";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // sToggleButton1
        // 
        sToggleButton1.Anchor = AnchorStyles.Right;
        sToggleButton1.AutoSize = true;
        sToggleButton1.BackColor = Color.White;
        sToggleButton1.Checked = true;
        sToggleButton1.CheckState = CheckState.Checked;
        sToggleButton1.Location = new Point(888, 32);
        sToggleButton1.Margin = new Padding(4);
        sToggleButton1.MinimumSize = new Size(56, 28);
        sToggleButton1.Name = "sToggleButton1";
        sToggleButton1.OffBackColor = SystemColors.GrayText;
        sToggleButton1.OffToggleColor = Color.Gainsboro;
        sToggleButton1.OnBackColor = Color.FromArgb(42, 38, 207);
        sToggleButton1.OnToggleColor = Color.WhiteSmoke;
        sToggleButton1.Size = new Size(56, 28);
        sToggleButton1.TabIndex = 13;
        sToggleButton1.UseVisualStyleBackColor = false;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Left;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(24, 24);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(176, 39);
        label5.TabIndex = 15;
        label5.Text = "Show process";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel3
        // 
        guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel3.BorderColor = SystemColors.ActiveBorder;
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.BorderThickness = 2;
        guna2Panel3.Controls.Add(label6);
        guna2Panel3.Controls.Add(label7);
        guna2Panel3.Controls.Add(sToggleButton2);
        guna2Panel3.Controls.Add(label8);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Location = new Point(24, 400);
        guna2Panel3.Margin = new Padding(2);
        guna2Panel3.Name = "guna2Panel3";
        guna2Panel3.Size = new Size(976, 88);
        guna2Panel3.TabIndex = 16;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Right;
        label6.BackColor = Color.Transparent;
        label6.Location = new Point(768, 24);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(96, 39);
        label6.TabIndex = 14;
        label6.Text = "Enabled";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Left;
        label7.BackColor = Color.Transparent;
        label7.Location = new Point(216, 24);
        label7.Margin = new Padding(2, 0, 2, 0);
        label7.Name = "label7";
        label7.Size = new Size(338, 39);
        label7.TabIndex = 14;
        label7.Text = "Send Diagnosticdata";
        label7.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // sToggleButton2
        // 
        sToggleButton2.Anchor = AnchorStyles.Right;
        sToggleButton2.AutoSize = true;
        sToggleButton2.BackColor = Color.White;
        sToggleButton2.Checked = true;
        sToggleButton2.CheckState = CheckState.Checked;
        sToggleButton2.Location = new Point(888, 32);
        sToggleButton2.Margin = new Padding(4);
        sToggleButton2.MinimumSize = new Size(56, 28);
        sToggleButton2.Name = "sToggleButton2";
        sToggleButton2.OffBackColor = SystemColors.GrayText;
        sToggleButton2.OffToggleColor = Color.Gainsboro;
        sToggleButton2.OnBackColor = Color.FromArgb(42, 38, 207);
        sToggleButton2.OnToggleColor = Color.WhiteSmoke;
        sToggleButton2.Size = new Size(56, 28);
        sToggleButton2.TabIndex = 13;
        sToggleButton2.UseVisualStyleBackColor = false;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Left;
        label8.BackColor = Color.Transparent;
        label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label8.Location = new Point(24, 24);
        label8.Margin = new Padding(2, 0, 2, 0);
        label8.Name = "label8";
        label8.Size = new Size(176, 39);
        label8.TabIndex = 15;
        label8.Text = "Diagnostics";
        label8.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel4
        // 
        guna2Panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel4.BorderColor = SystemColors.ActiveBorder;
        guna2Panel4.BorderRadius = 15;
        guna2Panel4.BorderThickness = 2;
        guna2Panel4.Controls.Add(label9);
        guna2Panel4.Controls.Add(label10);
        guna2Panel4.Controls.Add(sToggleButton3);
        guna2Panel4.Controls.Add(label11);
        guna2Panel4.FillColor = Color.White;
        guna2Panel4.Location = new Point(24, 504);
        guna2Panel4.Margin = new Padding(2);
        guna2Panel4.Name = "guna2Panel4";
        guna2Panel4.Size = new Size(976, 88);
        guna2Panel4.TabIndex = 16;
        // 
        // label9
        // 
        label9.Anchor = AnchorStyles.Right;
        label9.BackColor = Color.Transparent;
        label9.Location = new Point(768, 24);
        label9.Margin = new Padding(2, 0, 2, 0);
        label9.Name = "label9";
        label9.Size = new Size(96, 39);
        label9.TabIndex = 14;
        label9.Text = "Disabled";
        label9.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label10
        // 
        label10.Anchor = AnchorStyles.Left;
        label10.BackColor = Color.Transparent;
        label10.Location = new Point(216, 24);
        label10.Margin = new Padding(2, 0, 2, 0);
        label10.Name = "label10";
        label10.Size = new Size(338, 39);
        label10.TabIndex = 14;
        label10.Text = "Enabled the Pluginsupport";
        label10.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // sToggleButton3
        // 
        sToggleButton3.Anchor = AnchorStyles.Right;
        sToggleButton3.AutoSize = true;
        sToggleButton3.BackColor = Color.White;
        sToggleButton3.Location = new Point(888, 32);
        sToggleButton3.Margin = new Padding(4);
        sToggleButton3.MinimumSize = new Size(56, 28);
        sToggleButton3.Name = "sToggleButton3";
        sToggleButton3.OffBackColor = SystemColors.GrayText;
        sToggleButton3.OffToggleColor = Color.Gainsboro;
        sToggleButton3.OnBackColor = Color.FromArgb(42, 38, 207);
        sToggleButton3.OnToggleColor = Color.WhiteSmoke;
        sToggleButton3.Size = new Size(56, 28);
        sToggleButton3.TabIndex = 13;
        sToggleButton3.UseVisualStyleBackColor = false;
        // 
        // label11
        // 
        label11.Anchor = AnchorStyles.Left;
        label11.BackColor = Color.Transparent;
        label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label11.Location = new Point(24, 24);
        label11.Margin = new Padding(2, 0, 2, 0);
        label11.Name = "label11";
        label11.Size = new Size(176, 39);
        label11.TabIndex = 15;
        label11.Text = "Plugins";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // uiSettings
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1020, 948);
        Controls.Add(guna2Panel4);
        Controls.Add(guna2Panel3);
        Controls.Add(guna2Panel2);
        Controls.Add(guna2Panel1);
        Controls.Add(sPanel1);
        Name = "uiSettings";
        Text = "uiSettings";
        Load += uiSettings_Load;
        sPanel1.ResumeLayout(false);
        pnlFiles.ResumeLayout(false);
        pnlFiles.PerformLayout();
        guna2Panel1.ResumeLayout(false);
        guna2Panel1.PerformLayout();
        guna2Panel2.ResumeLayout(false);
        guna2Panel2.PerformLayout();
        guna2Panel3.ResumeLayout(false);
        guna2Panel3.PerformLayout();
        guna2Panel4.ResumeLayout(false);
        guna2Panel4.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Guna.UI2.WinForms.Guna2Button bntCancel;
    private Label lblText;
    private Telerik.WinControls.Themes.Windows11Theme windows11Theme1;
    private Guna.UI2.WinForms.Guna2Panel pnlFiles;
    private TextBox textBox1;
    private Label lblProductName;
    private Label label4;
    private Sipaa.Framework.SToggleButton tgl_diagnostics;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Label label1;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Label label2;
    private Label label3;
    private Sipaa.Framework.SToggleButton sToggleButton1;
    private Label label5;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Label label6;
    private Label label7;
    private Sipaa.Framework.SToggleButton sToggleButton2;
    private Label label8;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    private Label label9;
    private Label label10;
    private Sipaa.Framework.SToggleButton sToggleButton3;
    private Label label11;
}