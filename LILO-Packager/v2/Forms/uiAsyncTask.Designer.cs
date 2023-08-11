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
            label1 = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(40, 56);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "Preparing youre Files...";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(40, 112);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(496, 34);
            progressBar.TabIndex = 2;
            // 
            // uiAsyncTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(582, 215);
            ControlBox = false;
            Controls.Add(progressBar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(604, 271);
            MinimizeBox = false;
            MinimumSize = new Size(604, 271);
            Name = "uiAsyncTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preparing youre Files";
            Load += uiAsyncTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ProgressBar progressBar;
    }
}