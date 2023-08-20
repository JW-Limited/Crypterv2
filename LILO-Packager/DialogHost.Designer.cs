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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogHost));
        FormEdit = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
        header = new Sipaa.Framework.SPanel();
        lblDialogTitle = new Label();
        closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
        DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
        bntCancel = new Guna.UI2.WinForms.Guna2Button();
        bntSecond = new Guna.UI2.WinForms.Guna2Button();
        lblContent = new Label();
        MessageIconShower = new Sipaa.Framework.SPanel();
        header.SuspendLayout();
        SuspendLayout();
        // 
        // FormEdit
        // 
        FormEdit.AnimateWindow = true;
        FormEdit.AnimationInterval = 250;
        FormEdit.BorderRadius = 20;
        FormEdit.ContainerControl = this;
        FormEdit.DockForm = false;
        FormEdit.DockIndicatorTransparencyValue = 0.6D;
        FormEdit.DragForm = false;
        FormEdit.DragStartTransparencyValue = 1D;
        FormEdit.ShadowColor = Color.Silver;
        FormEdit.TransparentWhileDrag = true;
        // 
        // header
        // 
        header.BackColor = Color.FromArgb(17, 17, 17);
        header.BorderColor = Color.PaleVioletRed;
        header.BorderRadius = 6;
        header.BorderSize = 0;
        header.Controls.Add(lblDialogTitle);
        header.Controls.Add(closeButton);
        header.Dock = DockStyle.Top;
        header.ForeColor = Color.White;
        header.Location = new Point(0, 0);
        header.Name = "header";
        header.Size = new Size(656, 31);
        header.TabIndex = 1;
        // 
        // lblDialogTitle
        // 
        lblDialogTitle.AutoSize = true;
        lblDialogTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblDialogTitle.ForeColor = Color.LightGray;
        lblDialogTitle.Location = new Point(13, 3);
        lblDialogTitle.Name = "lblDialogTitle";
        lblDialogTitle.Size = new Size(41, 25);
        lblDialogTitle.TabIndex = 1;
        lblDialogTitle.Text = "title";
        // 
        // closeButton
        // 
        closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        closeButton.Animated = true;
        closeButton.BorderRadius = 3;
        closeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
        closeButton.FillColor = Color.FromArgb(17, 17, 17);
        closeButton.HoverState.FillColor = Color.Red;
        closeButton.IconColor = Color.White;
        closeButton.Location = new Point(588, 0);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(68, 31);
        closeButton.TabIndex = 0;
        // 
        // DragController
        // 
        DragController.DockIndicatorColor = Color.FromArgb(17, 17, 17);
        DragController.DockIndicatorTransparencyValue = 0.6D;
        DragController.DragStartTransparencyValue = 1D;
        DragController.TargetControl = header;
        DragController.UseTransparentDrag = true;
        // 
        // bntCancel
        // 
        bntCancel.Animated = true;
        bntCancel.BorderRadius = 10;
        bntCancel.DialogResult = DialogResult.Cancel;
        bntCancel.DisabledState.BorderColor = Color.DarkGray;
        bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCancel.FillColor = Color.FromArgb(64, 64, 64);
        bntCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        bntCancel.ForeColor = Color.White;
        bntCancel.Location = new Point(456, 296);
        bntCancel.Name = "bntCancel";
        bntCancel.Size = new Size(166, 39);
        bntCancel.TabIndex = 2;
        bntCancel.Text = "Cancel";
        bntCancel.Click += bntCancel_Click;
        // 
        // bntSecond
        // 
        bntSecond.Animated = true;
        bntSecond.BorderRadius = 10;
        bntSecond.DialogResult = DialogResult.OK;
        bntSecond.DisabledState.BorderColor = Color.DarkGray;
        bntSecond.DisabledState.CustomBorderColor = Color.DarkGray;
        bntSecond.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntSecond.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntSecond.FillColor = Color.FromArgb(64, 64, 64);
        bntSecond.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        bntSecond.ForeColor = Color.White;
        bntSecond.Location = new Point(272, 296);
        bntSecond.Name = "bntSecond";
        bntSecond.Size = new Size(166, 39);
        bntSecond.TabIndex = 2;
        bntSecond.Text = "n/a";
        bntSecond.Click += guna2Button2_Click;
        // 
        // lblContent
        // 
        lblContent.Font = new Font("Corbel", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblContent.ForeColor = SystemColors.ButtonHighlight;
        lblContent.Location = new Point(209, 72);
        lblContent.Name = "lblContent";
        lblContent.Size = new Size(417, 192);
        lblContent.TabIndex = 3;
        lblContent.Text = "here will be displayed the Message";
        lblContent.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MessageIconShower
        // 
        MessageIconShower.BackColor = Color.FromArgb(64, 64, 64);
        MessageIconShower.BackgroundImageLayout = ImageLayout.Center;
        MessageIconShower.BorderColor = Color.PaleVioletRed;
        MessageIconShower.BorderRadius = 20;
        MessageIconShower.BorderSize = 0;
        MessageIconShower.ForeColor = Color.White;
        MessageIconShower.Location = new Point(35, 72);
        MessageIconShower.Name = "MessageIconShower";
        MessageIconShower.Size = new Size(147, 141);
        MessageIconShower.TabIndex = 4;
        // 
        // DialogHost
        // 
        AcceptButton = bntSecond;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        CancelButton = bntCancel;
        ClientSize = new Size(656, 356);
        ControlBox = false;
        Controls.Add(MessageIconShower);
        Controls.Add(lblContent);
        Controls.Add(bntSecond);
        Controls.Add(bntCancel);
        Controls.Add(header);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Name = "DialogHost";
        StartPosition = FormStartPosition.CenterParent;
        Text = "DialogHost";
        Load += DialogHost_Load;
        header.ResumeLayout(false);
        header.PerformLayout();
        ResumeLayout(false);
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