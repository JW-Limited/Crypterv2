using Microsoft.Win32;

namespace InstallHelper.Core
{
    public class ProductRegistration
    {
        public static void RegisterProduct(string productName, string productVersion, string productLocation)
        {
            using (RegistryKey key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + productName))
            {
                key.SetValue("DisplayName", productName);
                key.SetValue("DisplayVersion", productVersion);
                key.SetValue("Publisher", "JW Limited");
                key.SetValue("InstallLocation", Path.GetDirectoryName(productLocation));
                key.SetValue("UninstallString", "\"" + productLocation + "\" /uninstall");
                key.SetValue("QuietUninstallString", "\"" + productLocation + "\" /uninstall /quiet");
                key.SetValue("SystemComponent", 0);
                key.SetValue("EstimatedSize", new FileInfo(productLocation).Length / 1024);

                string iconLocation = productLocation;
                if (File.Exists(iconLocation))
                {
                    key.SetValue("DisplayIcon", iconLocation);
                }
            }
        }
    }
}
