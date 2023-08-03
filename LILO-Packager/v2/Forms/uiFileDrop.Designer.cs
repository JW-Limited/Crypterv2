namespace LILO_Packager.v2.Forms;

partial class uiFileDrop
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
        SuspendLayout();
        // 
        // uiFileDrop
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonHighlight;
        BackgroundImage = Properties.Resources.OIP;
        BackgroundImageLayout = ImageLayout.Zoom;
        ClientSize = new Size(306, 400);
        Name = "uiFileDrop";
        Text = "uiFileDrop";
        Load += uiFileDrop_Load;
        ResumeLayout(false);
    }

    #endregion
}