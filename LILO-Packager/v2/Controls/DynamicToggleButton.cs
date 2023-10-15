

namespace LILO_Packager.v2.Controls
{
    public partial class DynamicToggleButton : UserControl
    {
        public DynamicToggleButton()
        {
            InitializeComponent();

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {
                toggleButton.OnBackColor = CheckedColor;

                if(EnabledState)
                {
                    if (Checked)
                    {
                        label41.Text = CheckedText;
                        toggleButton.Checked = Checked;
                    }
                    else
                    {
                        label41.Text = UnCheckedText;
                        toggleButton.Checked = Checked;
                    }
                }
                else
                {
                    label41.Text = DisabledText;
                    toggleButton.Enabled = EnabledState;
                }
            };

            timer.Start();
        }

        public event EventHandler Clicked;

        public bool EnabledState { get; set; } = true;
        public bool Checked { get; set; } = false;
        public string CheckedText { get; set; } = "Enabled";
        public string UnCheckedText { get; set; } = "Disabled";
        public string DisabledText { get; set; } = "Not Changable";
        public Color CheckedColor { get; set; } = Color.FromArgb(94, 148, 255);
        public override Color BackColor { get => pnlBackGround.FillColor; set => pnlBackGround.FillColor = value; }
        public Color ForeColor { get => label41.ForeColor; set => label41.ForeColor = value; }
        public override Font Font { get => label41.Font ; set => label41.Font = value; }
        public int BorderRadius { get => pnlBackGround.BorderRadius; set => pnlBackGround.BorderRadius = value; }
        public Color BorderColor { get => pnlBackGround.BorderColor; set => pnlBackGround.BorderColor = value; }

        private void pnlBackGround_Click(object sender, EventArgs e)
        {
            if (EnabledState)
            {
                Checked = !Checked;
                Clicked?.Invoke(this, e);

                if (Checked)
                {
                    label41.Text = CheckedText;
                    toggleButton.Checked = Checked;
                }
                else
                {
                    label41.Text = UnCheckedText;
                    toggleButton.Checked = Checked;
                }
            }
           
        }

        public void CheckControl(bool value)
        {
            Checked = value;

            if (Checked)
            {
                label41.Text = CheckedText;
                toggleButton.Checked = Checked;
            }
            else
            {
                label41.Text = UnCheckedText;
                toggleButton.Checked = Checked;
            }
        }
    }
}
