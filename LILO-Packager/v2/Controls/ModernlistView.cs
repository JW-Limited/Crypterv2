namespace LILO_Packager.v2.Controls
{
    public class ModernListView : UserControl
    {
        private ListBox _listBox;
        private Panel _panel;
        private List<IRenderer> _renderers;

        public ModernListView()
        {
            _panel = new Panel();
            _listBox = new ListBox();

            _panel.Dock = DockStyle.Fill;

            this.Controls.Add(_panel);
            _panel.Controls.Add(_listBox);

            _listBox.Dock = DockStyle.Fill;
            _listBox.DrawMode = DrawMode.OwnerDrawVariable;

            _renderers = new List<IRenderer>();
        }

        public override string Text 
        {
            get { return _listBox.Text; }
            set { _listBox.Text = value; }
        }

        public override Image? BackgroundImage 
        {
            get => base.BackgroundImage; 
            set => base.BackgroundImage = value;
        }

        public override Font Font
        {
            get { return _listBox.Font; }
            set { _listBox.Font = value; }
        }

        public override Color ForeColor
        {
            get { return _listBox.ForeColor; }
            set { _listBox.ForeColor = value; }
        }

        public override Color BackColor
        {
            get { return _listBox.BackColor; }
            set { _listBox.BackColor = value; _listBox.BackColor = value; }
        }

        public override DockStyle Dock
        {
            get { return _listBox.Dock; }
            set { _listBox.Dock = value; }
        }

        public ListBox ListBox
        {
            get { return _listBox; }
            set { _listBox = value; }
        }

        public new void Add(object item)
        {
            _listBox.Items.Add(item);
        }

        public IEnumerable<IRenderer> Renderers
        {
            get { return _renderers; }
        }

        public void AddRenderer(IRenderer renderer)
        {
            _renderers.Add(renderer);
        }

        public void RemoveRenderer(IRenderer renderer)
        {
            _renderers.Remove(renderer);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var renderer in _renderers)
            {
                renderer.Render(e);
            }
        }

        #region Renderers

        public interface IRenderer
        {
            void Render(PaintEventArgs e);
        }


        #endregion
    }
}
