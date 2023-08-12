using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallHelper.Core
{
    public class ExtensionBinder
    {
        public static void RegisterContextMenuEntry(string exePath)
        {
            string command = $"\"{exePath}\" \"%1\"";

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey("*\\shell\\EncryptWithCrypterv2"))
            {
                key.SetValue(null, "Encrypt with Crypterv2");
                key.CreateSubKey("command").SetValue(null, command);
            }
        }

        public static string SetCustomFileHandlerAsync(string path)
        {
            string exePath = path;
            string fileExtension = ".lsf";
            string description = "LILO secured File";
            string friendlyTypeName = "LILO Encrypted File";
            string contentType = "application/lilo-encrypted"; //


            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}", null, description);

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}", "FriendlyTypeName", friendlyTypeName);

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}\\Content Type", null, contentType);

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}\\shell\\open\\command", null, $"{exePath} \"%1\"");

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}", null, description);

            return "Completed Succesfull";
        }
    }
}
