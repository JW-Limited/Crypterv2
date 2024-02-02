using NuGet.Common;

namespace LILO_Packager.v2.Core.Visuals
{
    public class HostForm : Form
    {
        private Form _form = null;
        private Theme _theme = null;
        private Control _control = null;

        public Form ControllableForm
        {
            get
            {
                return _form;
            }

            private set
            {
                if(_form != value && value is not null)
                {
                    _form = value;
                }
            }
        }

        public Theme AppliedTheme
        {
            get
            {
                return _theme ?? ThemeManager.Initialize().Themes.GetValueOrDefault("White",null);
            }
        }

        public Control HostControlHandle
        {
            get
            {
                return _control;
            }
            set
            {
                if( _control != value && value is not null)
                {
                    _control = value; 
                }

            }
        }

        public void SetFormValue(MainHost form)
        {
            ControllableForm = form;
            HostControlHandle = form;
        }
        public void SetTheme(Theme theme)
        {

            if (_theme != theme && theme is not null)
            {
                _theme = theme;
            }
        }

    }
}
