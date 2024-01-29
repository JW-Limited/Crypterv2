using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TextPreviewLibrary.Controls;

namespace TextPreviewLibrary.Core.Tabs
{
    public class TabManager
    {
        public static TabManager Instance 
        {
            get => _Instance.Value;
        }

        private static Lazy<TabManager> _Instance = new Lazy<TabManager>();

        private readonly HashSet<Tab> FilesOpen = new HashSet<Tab>();

        public class Tab
        {
            public string Name { get; set; }
            public object Content { get; set; }
            public bool IsFile { get; set; }
            public string FileName { get; set; }
            public DynamikPluginListItem TabUI { get; set; }
        }

        public void RegisterTab(string tabName, object Text, PluginInterface interF ,string filename = null)
        {
            interF.Invoke(() =>
            {
                var tab = new Tab { Name = tabName, Content = Text };
                if (filename != null && File.Exists(filename))
                {
                    tab.IsFile = true;
                    tab.FileName = filename;
                }

                var uiElement = new DynamikPluginListItem()
                {
                    TabName = tabName,
                    _form = interF,
                    Content = (string)Text,
                };

                tab.TabUI = uiElement;

                FilesOpen.Add(tab);

                uiElement.Show();
                interF.pnlTabs.Controls.Add(uiElement);
                uiElement.Location = new Point(interF.Widht, 0);
                uiElement.Height = interF.pnlTabs.Height - 2;
                interF.Widht += uiElement.Width + 20;
            });
           
        }
    }
}
