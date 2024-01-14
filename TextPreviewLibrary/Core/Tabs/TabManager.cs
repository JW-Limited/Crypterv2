using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPreviewLibrary.Core.Tabs
{
    public class TabManager
    {
        public static TabManager Instance 
        { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new TabManager();
                }

                return _Instance;
            }
            private set 
            { 
                if (_Instance != value)
                {
                    _Instance = value;
                }
            } 
        }

        private static TabManager _Instance = null;

        public void RegisterTab()
        {

        }
    }
}
