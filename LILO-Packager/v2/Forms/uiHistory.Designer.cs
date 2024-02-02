namespace LILO_Packager.v2.Forms
{
    partial class uiHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiHistory));
            tableLayoutPanel1 = new TableLayoutPanel();
            listViewHistory = new HTAlt.WinForms.HTListView();
            ColId = new ColumnHeader();
            ColOperation = new ColumnHeader();
            ColMode = new ColumnHeader();
            ColVersion = new ColumnHeader();
            ColInput = new ColumnHeader();
            ColOutput = new ColumnHeader();
            conmenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            viewToolStripMenuItem = new ToolStripMenuItem();
            showInExplorerToolStripMenuItem = new ToolStripMenuItem();
            explorerToolStripMenuItem = new ToolStripMenuItem();
            lILOWebEngineToolStripMenuItem = new ToolStripMenuItem();
            compareToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reportToolStripMenuItem = new ToolStripMenuItem();
            sPanel2 = new Sipaa.Framework.SPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            textBox1 = new TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            tableLayoutPanel1.SuspendLayout();
            conmenu.SuspendLayout();
            sPanel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            pnlLoginLoad.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(listViewHistory, 0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // listViewHistory
            // 
            listViewHistory.Activation = ItemActivation.OneClick;
            resources.ApplyResources(listViewHistory, "listViewHistory");
            listViewHistory.AllowColumnReorder = true;
            listViewHistory.BorderStyle = BorderStyle.None;
            listViewHistory.Columns.AddRange(new ColumnHeader[] { ColId, ColOperation, ColMode, ColVersion, ColInput, ColOutput });
            listViewHistory.ContextMenuStrip = conmenu;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewHistory.HeaderBorderThickness = 2;
            listViewHistory.HeaderForeColor = Color.Black;
            listViewHistory.HideSelection = true;
            listViewHistory.HoverSelection = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { (ListViewItem)resources.GetObject("listViewHistory.Items") });
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.OverlayColor = Color.DodgerBlue;
            listViewHistory.ShowGroups = false;
            listViewHistory.ShowItemToolTips = true;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            listViewHistory.SelectedIndexChanged += listViewBerechtigungen_SelectedIndexChanged;
            // 
            // ColId
            // 
            ColId.Tag = "ID";
            resources.ApplyResources(ColId, "ColId");
            // 
            // ColOperation
            // 
            ColOperation.Tag = "Opration";
            resources.ApplyResources(ColOperation, "ColOperation");
            // 
            // ColMode
            // 
            resources.ApplyResources(ColMode, "ColMode");
            // 
            // ColVersion
            // 
            resources.ApplyResources(ColVersion, "ColVersion");
            // 
            // ColInput
            // 
            resources.ApplyResources(ColInput, "ColInput");
            // 
            // ColOutput
            // 
            resources.ApplyResources(ColOutput, "ColOutput");
            // 
            // conmenu
            // 
            conmenu.BackColor = Color.White;
            conmenu.ImageScalingSize = new Size(24, 24);
            conmenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, toolStripSeparator1, viewToolStripMenuItem, showInExplorerToolStripMenuItem, compareToolStripMenuItem, toolStripSeparator2, reportToolStripMenuItem });
            conmenu.Name = "ConMenu";
            conmenu.RenderStyle.ArrowColor = Color.FromArgb(125, 100, 255);
            conmenu.RenderStyle.BorderColor = Color.Black;
            conmenu.RenderStyle.ColorTable = null;
            conmenu.RenderStyle.RoundedEdges = true;
            conmenu.RenderStyle.SelectionArrowColor = Color.White;
            conmenu.RenderStyle.SelectionBackColor = Color.FromArgb(94, 148, 255);
            conmenu.RenderStyle.SelectionForeColor = Color.White;
            conmenu.RenderStyle.SeparatorColor = Color.LightGray;
            conmenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            resources.ApplyResources(conmenu, "conmenu");
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(deleteToolStripMenuItem, "deleteToolStripMenuItem");
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // showInExplorerToolStripMenuItem
            // 
            showInExplorerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { explorerToolStripMenuItem, lILOWebEngineToolStripMenuItem });
            showInExplorerToolStripMenuItem.Name = "showInExplorerToolStripMenuItem";
            resources.ApplyResources(showInExplorerToolStripMenuItem, "showInExplorerToolStripMenuItem");
            showInExplorerToolStripMenuItem.Click += showInExplorerToolStripMenuItem_Click;
            // 
            // explorerToolStripMenuItem
            // 
            explorerToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            resources.ApplyResources(explorerToolStripMenuItem, "explorerToolStripMenuItem");
            explorerToolStripMenuItem.Click += explorerToolStripMenuItem_Click;
            // 
            // lILOWebEngineToolStripMenuItem
            // 
            lILOWebEngineToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            lILOWebEngineToolStripMenuItem.Name = "lILOWebEngineToolStripMenuItem";
            resources.ApplyResources(lILOWebEngineToolStripMenuItem, "lILOWebEngineToolStripMenuItem");
            lILOWebEngineToolStripMenuItem.Click += lILOWebEngineToolStripMenuItem_Click;
            // 
            // compareToolStripMenuItem
            // 
            compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            resources.ApplyResources(compareToolStripMenuItem, "compareToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            resources.ApplyResources(reportToolStripMenuItem, "reportToolStripMenuItem");
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // sPanel2
            // 
            resources.ApplyResources(sPanel2, "sPanel2");
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(guna2Panel1);
            sPanel2.Controls.Add(guna2Button1);
            sPanel2.Controls.Add(bntPlugin);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Name = "sPanel2";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(textBox1);
            guna2Panel1.FillColor = Color.White;
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.Name = "guna2Panel1";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // guna2Button1
            // 
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Click += bntSync_Click;
            // 
            // bntPlugin
            // 
            resources.ApplyResources(bntPlugin, "bntPlugin");
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 20;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.White;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.ForeColor = Color.DimGray;
            bntPlugin.Image = Properties.Resources.icons8_synchronize_240;
            bntPlugin.ImageSize = new Size(30, 30);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Click += bntPlugin_Click;
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
            bntCancel.FillColor = Color.Transparent;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.ForeColor = Color.White;
            bntCancel.Name = "bntCancel";
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            resources.ApplyResources(lblText, "lblText");
            lblText.ForeColor = Color.DimGray;
            lblText.Name = "lblText";
            // 
            // pnlLoginLoad
            // 
            resources.ApplyResources(pnlLoginLoad, "pnlLoginLoad");
            pnlLoginLoad.BackColor = Color.Transparent;
            pnlLoginLoad.BorderColor = Color.Silver;
            pnlLoginLoad.BorderRadius = 15;
            pnlLoginLoad.Controls.Add(progressSpinner);
            pnlLoginLoad.FillColor = Color.White;
            pnlLoginLoad.Name = "pnlLoginLoad";
            // 
            // progressSpinner
            // 
            resources.ApplyResources(progressSpinner, "progressSpinner");
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.Name = "progressSpinner";
            // 
            // uiHistory
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(pnlLoginLoad);
            Controls.Add(sPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "uiHistory";
            Load += uiHistory_Load;
            tableLayoutPanel1.ResumeLayout(false);
            conmenu.ResumeLayout(false);
            sPanel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            pnlLoginLoad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip conmenu;
        private TableLayoutPanel tableLayoutPanel1;
        private HTAlt.WinForms.HTListView listViewHistory;
        private ColumnHeader ColId;
        private ColumnHeader ColOperation;
        private ColumnHeader ColMode;
        private ColumnHeader ColVersion;
        private ColumnHeader ColInput;
        private ColumnHeader ColOutput;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label lblText;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem compareToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem reportToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TextBox textBox1;
        private ToolStripMenuItem showInExplorerToolStripMenuItem;
        private ToolStripMenuItem explorerToolStripMenuItem;
        private ToolStripMenuItem lILOWebEngineToolStripMenuItem;
    }
}