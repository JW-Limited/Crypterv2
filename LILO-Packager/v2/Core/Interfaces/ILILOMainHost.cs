using LILO_Packager.v2.Core;
using LILO_Packager.v2.Plugins.Model;
using srvlocal_gui.AppMananger;
using System.Collections.ObjectModel;
using System.Net;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface ILILOMainHost : IFeatureFlagSwitcher
    {
        ObservableCollection<PluginEntry> plugins { get; set; }
        string UserFile { get; }

        Task CheckForUpdates(UpdateMode mode = UpdateMode.Manual);
        Task OpenDynamicPlayer(HttpListenerContext con, string fallbackFile);
        void OpenInApp(Form children, string FormName = null, MainHost.ChildrenUse usage = MainHost.ChildrenUse.WebView);
        void SetNotification(string Message);
        void ToggleFeature(FeatureFlags feature, bool isEnabled);
    }
}