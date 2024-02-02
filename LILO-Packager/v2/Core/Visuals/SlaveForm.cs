using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Visuals
{
    public class SlaveForm : Form
    {
        private Form _form = null;
        private Theme _theme = null;

        public Form ControllableForm
        {
            get
            {
                return _form;
            }

            private set
            {
                if (_form != value && value is not null)
                {
                    _form = value;
                }
            }
        }

        public Theme AppliedTheme
        {
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value && value is not null)
                {
                    _theme = value;
                }
            }
        }

        public SlaveForm(Form form)
        {
            ControllableForm = form;
        }
    }
}
