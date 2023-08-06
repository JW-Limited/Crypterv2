namespace LILO_Packager.v2.Forms
{
    partial class uiPluginManager
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Plugin", "1.0" }, -1);
            listView1 = new ListView();
            pluginName = new ColumnHeader();
            pluginVersion = new ColumnHeader();
            pluginEntryBindingSource = new BindingSource(components);
            sPanel2 = new Sipaa.Framework.SPanel();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource).BeginInit();
            sPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.AllowColumnReorder = true;
            listView1.AllowDrop = true;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.White;
            listView1.BackgroundImageTiled = true;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { pluginName, pluginVersion });
            listView1.DataBindings.Add(new Binding("DataContext", pluginEntryBindingSource, "PluginBase", true));
            listView1.DataBindings.Add(new Binding("Tag", pluginEntryBindingSource, "ID", true));
            listView1.ForeColor = SystemColors.Desktop;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(24, 152);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Size = new Size(968, 768);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // pluginName
            // 
            pluginName.Tag = "pluginName";
            pluginName.Text = "Plugin Name";
            pluginName.Width = 300;
            // 
            // pluginVersion
            // 
            pluginVersion.Tag = "pluginVersion";
            pluginVersion.Text = "Version";
            pluginVersion.Width = 90;
            // 
            // pluginEntryBindingSource
            // 
            pluginEntryBindingSource.DataSource = typeof(plugins.Model.PluginEntry);
            pluginEntryBindingSource.CurrentChanged += pluginEntryBindingSource_CurrentChanged;
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.Black;
            sPanel2.BackgroundImage = Properties.Resources.Aqua_Marine_180degree;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(975, 88);
            sPanel2.TabIndex = 12;
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
            bntCancel.Location = new Point(1657, 16);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(128, 58);
            bntCancel.TabIndex = 14;
            bntCancel.Text = "Cancel";
            bntCancel.Visible = false;
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
            lblText.Text = "Plugins";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiPluginManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1020, 948);
            Controls.Add(listView1);
            Controls.Add(sPanel2);
            Name = "uiPluginManager";
            Text = "uiPluginManager";
            Load += uiPluginManager_Load;
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource).EndInit();
            sPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label lblText;
        private BindingSource pluginEntryBindingSource;
        private ColumnHeader pluginName;
        private ColumnHeader pluginVersion;
    }
}