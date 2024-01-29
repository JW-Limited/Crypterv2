using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Collections.Frozen;

namespace LILO_Packager.v2.Plugins.Internal
{
    public class PluginRightsManager
    {
        private static Lazy<FrozenSet<PluginRightsManager>> _instance = new Lazy<FrozenSet<PluginRightsManager>>();
        public static PluginRightsManager Instance => _instance.Value.Items[0];

        private PluginRightsManager() 
        {

        }

        public async Task<byte> RequestPermission(Permission permission, PluginID pluginID, string name)
        {
            var data = PluginSystemManagement.Instance.GetPluginData(PluginID.IDtoString(pluginID) + name);
            if(data is null) throw new ArgumentNullException(nameof(data));

            var permissionSet = data.Permissions.FirstOrDefault(k => k.Permission.Type == permission.Type, null);
            if(permissionSet == null) throw new ArgumentNullException(nameof(permissionSet));
            if (permissionSet.Enabled) throw new AccessAlreadyGrantedException(permission.Type.ToString());

            var permissionUI = new uiPermissionRequest(permissionSet,data);
            return await permissionUI.RequestAccess();
        }
    }
}
