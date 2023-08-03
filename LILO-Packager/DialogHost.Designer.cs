namespace LILO;

partial class DialogHost
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogHost));
            this.FormEdit = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.header = new Sipaa.Framework.SPanel();
            this.lblDialogTitle = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragController = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.bntCancel = new Guna.UI2.WinForms.Guna2Button();
            this.bntSecond = new Guna.UI2.WinForms.Guna2Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.MessageIconShower = new Sipaa.Framework.SPanel();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormEdit
            // 
            this.FormEdit.AnimateWindow = true;
            this.FormEdit.AnimationInterval = 250;
            this.FormEdit.BorderRadius = 20;
            this.FormEdit.ContainerControl = this;
            this.FormEdit.DockForm = false;
            this.FormEdit.DockIndicatorTransparencyValue = 0.6D;
            this.FormEdit.DragForm = false;
            this.FormEdit.DragStartTransparencyValue = 1D;
            this.FormEdit.ShadowColor = System.Drawing.Color.Silver;
            this.FormEdit.TransparentWhileDrag = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.header.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.header.BorderRadius = 6;
            this.header.BorderSize = 0;
            this.header.Controls.Add(this.lblDialogTitle);
            this.header.Controls.Add(this.closeButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(666, 31);
            this.header.TabIndex = 1;
            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.AutoSize = true;
            this.lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDialogTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblDialogTitle.Location = new System.Drawing.Point(13, 3);
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.Size = new System.Drawing.Size(41, 25);
            this.lblDialogTitle.TabIndex = 1;
            this.lblDialogTitle.Text = "title";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Animated = true;
            this.closeButton.BorderRadius = 3;
            this.closeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.closeButton.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(598, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(68, 31);
            this.closeButton.TabIndex = 0;
            // 
            // DragController
            // 
            this.DragController.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DragController.DockIndicatorTransparencyValue = 0.6D;
            this.DragController.DragStartTransparencyValue = 1D;
            this.DragController.TargetControl = this.header;
            this.DragController.UseTransparentDrag = true;
            // 
            // bntCancel
            // 
            this.bntCancel.Animated = true;
            this.bntCancel.BorderRadius = 10;
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntCancel.ForeColor = System.Drawing.Color.White;
            this.bntCancel.Location = new System.Drawing.Point(460, 248);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(166, 39);
            this.bntCancel.TabIndex = 2;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntSecond
            // 
            this.bntSecond.Animated = true;
            this.bntSecond.BorderRadius = 10;
            this.bntSecond.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntSecond.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntSecond.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntSecond.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntSecond.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntSecond.ForeColor = System.Drawing.Color.White;
            this.bntSecond.Location = new System.Drawing.Point(273, 248);
            this.bntSecond.Name = "bntSecond";
            this.bntSecond.Size = new System.Drawing.Size(166, 39);
            this.bntSecond.TabIndex = 2;
            this.bntSecond.Text = "n/a";
            this.bntSecond.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // lblContent
            // 
            this.lblContent.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContent.Location = new System.Drawing.Point(209, 72);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(417, 141);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "here will be displayed the Message";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageIconShower
            // 
            this.MessageIconShower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MessageIconShower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MessageIconShower.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MessageIconShower.BorderRadius = 20;
            this.MessageIconShower.BorderSize = 0;
            this.MessageIconShower.ForeColor = System.Drawing.Color.White;
            this.MessageIconShower.Location = new System.Drawing.Point(35, 72);
            this.MessageIconShower.Name = "MessageIconShower";
            this.MessageIconShower.Size = new System.Drawing.Size(147, 141);
            this.MessageIconShower.TabIndex = 4;
            // 
            // DialogHost
            // 
            this.AcceptButton = this.bntSecond;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(666, 315);
            this.ControlBox = false;
            this.Controls.Add(this.MessageIconShower);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.bntSecond);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DialogHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogHost";
            this.Load += new System.EventHandler(this.DialogHost_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Guna.UI2.WinForms.Guna2BorderlessForm FormEdit;
    private Sipaa.Framework.SPanel header;
    private Label lblDialogTitle;
    private Guna.UI2.WinForms.Guna2ControlBox closeButton;
    private Guna.UI2.WinForms.Guna2DragControl DragController;
    private Guna.UI2.WinForms.Guna2Button bntSecond;
    private Guna.UI2.WinForms.Guna2Button bntCancel;
    private Sipaa.Framework.SPanel MessageIconShower;
    private Label lblContent;
}