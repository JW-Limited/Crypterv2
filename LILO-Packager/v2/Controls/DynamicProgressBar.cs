using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace LILO_Packager.v2.Controls
{
    public class DynamicProgressBar : Control
    {
        private Graphics _graphics;
        private LinearGradientBrush _gradientBrush;
        private Timer _timer;
        private float _progress;
        private bool _isAnimating;

        public DynamicProgressBar()
        {
            _graphics = this.CreateGraphics();
            _gradientBrush = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color.LimeGreen, Color.Yellow, LinearGradientMode.Horizontal);
            _timer = new Timer();
            _timer.Interval = 10;
            _timer.Tick += Timer_Tick;

            _progress = 0;
            _isAnimating = false;

            this.Width = 100;
            this.Height = 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Width = 100;
            this.Height = 20;

            base.OnPaint(e);

            int progressBarWidth = (int)(this.Width * _progress);

            _graphics.FillRectangle(_gradientBrush, new Rectangle(1, 1, progressBarWidth, this.Height));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_progress < 1)
            {
                _progress += 0.01f;
                this.Invalidate();
            }
            else
            {
                _isAnimating = false;
                _timer.Stop();
            }
        }

        public void StartAnimation()
        {
            if (!_isAnimating)
            {
                _isAnimating = true;
                _timer.Start();
            }
        }

        public void StopAnimation()
        {
            if (_isAnimating)
            {
                _isAnimating = false;
                _timer.Stop();
            }
        }

        public float Progress
        {
            get { return _progress; }
            set
            {
                _progress = value;
                this.Invalidate();
            }
        }
    }

}
