namespace LILO_Packager.v2.Forms
{
    partial class uiAsyncTask
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
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(32, 54);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(504, 34);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 2;
            // 
            // uiAsyncTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(582, 140);
            ControlBox = false;
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(604, 271);
            MinimizeBox = false;
            Name = "uiAsyncTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preparing youre Files";
            Load += uiAsyncTask_Load;
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressBar;
    }
}