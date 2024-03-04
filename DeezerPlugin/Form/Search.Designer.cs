namespace DeezerPlugin.Forms
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new System.Windows.Forms.Panel();
            txtPsw = new Sipaa.Framework.STextBox();
            SuspendLayout();
            // 
            // guna2Button2
            // 
            resources.ApplyResources(guna2Button2, "guna2Button2");
            guna2Button2.Animated = true;
            guna2Button2.BackColor = System.Drawing.Color.Transparent;
            guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = System.Drawing.Color.WhiteSmoke;
            guna2Button2.FocusedColor = System.Drawing.Color.FromArgb(100, 170, 209);
            guna2Button2.ForeColor = System.Drawing.Color.DimGray;
            guna2Button2.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            guna2Button2.HoverState.FillColor = System.Drawing.Color.Silver;
            guna2Button2.HoverState.ForeColor = System.Drawing.Color.BlueViolet;
            guna2Button2.Name = "guna2Button2";
            guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // txtPsw
            // 
            txtPsw.BackColor = System.Drawing.Color.White;
            txtPsw.BorderColor = System.Drawing.Color.Gainsboro;
            txtPsw.BorderFocusColor = System.Drawing.Color.DimGray;
            txtPsw.BorderRadius = 14;
            txtPsw.BorderSize = 1;
            resources.ApplyResources(txtPsw, "txtPsw");
            txtPsw.ForeColor = System.Drawing.Color.Black;
            txtPsw.Multiline = false;
            txtPsw.Name = "txtPsw";
            txtPsw.PasswordChar = true;
            txtPsw.PlaceholderColor = System.Drawing.Color.DarkGray;
            txtPsw.PlaceholderText = "Search";
            txtPsw.Texts = "";
            txtPsw.UnderlinedStyle = false;
            // 
            // Search
            // 
            BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            Controls.Add(txtPsw);
            Controls.Add(guna2Button2);
            Controls.Add(panel1);
            Name = "Search";
            Load += PluginInterface_Load;
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel1;
        private Sipaa.Framework.STextBox txtPsw;
    }
}