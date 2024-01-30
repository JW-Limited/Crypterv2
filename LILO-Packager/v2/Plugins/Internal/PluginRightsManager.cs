using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Collections.Frozen;

namespace LILO_Packager.v2.Plugins.Internal
{
    public class PluginRightsManager
    {
        private static Lazy<PluginRightsManager> _instance = new Lazy<PluginRightsManager>(() => new PluginRightsManager());
        public static PluginRightsManager Instance => _instance.Value;

        public async Task<byte> RequestPermission(Permission permission, PluginID pluginID, string name)
        {
            var data = PluginSystemManagement.Instance.GetPluginData(PluginID.IDtoString(pluginID) + name);
            if(data is null) throw new ArgumentNullException(nameof(data));

            var permissionSet = data.Permissions.FirstOrDefault(k => k.Permission.Type == permission.Type, null);
            if(permissionSet == null) throw new ArgumentNullException(nameof(permissionSet));
            if (permissionSet.Enabled) throw new AccessAlreadyGrantedException(permission.Type.ToString());

            var permissionUI = new uiPermissionRequest(permissionSet,data);
            permissionUI.StartPosition = FormStartPosition.CenterParent;
            permissionUI.ShowInTaskbar = false;
            var result = await permissionUI.RequestAccess();

            if(result == 1)
            {
                return await SetPermissionState(permission,true,data,pluginID,name);
            }

            return 0;
        }

        public async Task<byte> CheckPermission(Permission permission, PluginID pluginID, string name)
        {
            var data = PluginSystemManagement.Instance.GetPluginData(PluginID.IDtoString(pluginID) + name);
            if (data is null) throw new ArgumentNullException(nameof(data));
            await Task.Delay(100);
            var permissionSet = data.Permissions.FirstOrDefault(k => k.Permission.Type == permission.Type, null);
            if (permissionSet == null) throw new ArgumentNullException(nameof(permissionSet));
            if (permissionSet.Enabled) return 1;

            return 0;
        }

        public async Task<byte> SetPermissionState(Permission permission, bool enabled, PluginData PluginData, PluginID pluginID, string name)
        {
            try
            {
                var entry = PluginData.Permissions.FirstOrDefault(k => k.Permission.Type == permission.Type && k.Permission.Description == permission.Description, null);
                if (entry != null)
                {
                    PluginData.Permissions.Remove(entry);
                    var _PermissionSet = new PluginData.PermissionSet()
                    {
                        Permission = permission,
                        Enabled = enabled
                    };

                    PluginData.Permissions.Add(_PermissionSet);

                    PluginSystemManagement.Instance.UpdatePlugin(PluginID.IDtoString(pluginID) + name, PluginData);

                    await Task.Delay(100);

                    return 1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant change this plugin attribute.\n" + ex.Message + ex.Source + ex.StackTrace, "Manifest Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
    }
}
