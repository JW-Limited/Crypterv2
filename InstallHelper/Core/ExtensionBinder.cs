using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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


            SetCustomFileHandler(path, ".lsf", "LILO Secured File", "LILO Secured File", "application/encrypted-data");
            SetCustomFileHandler(path, ".lcs", "LILO Custom Style", "LILO Custom Style", "application/json");
            SetCustomFileHandler(path, ".dbgsl", "Crypterv2 Debug Session", "Crypterv2 Debug Session", "plain/text"); 
            SetCustomFileHandler(path, ".cryptex", "Crypterv2 Extension", "Crypterv2 Extension", "application/plugin");


            return "Completed Succesfull";
        }

        public static string SetCustomFileHandler(string exePath, string fileExtension, string description, string friendlyTypeName, string contentType, bool registerIcon = true)
        {
            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}", null, description);

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}", "FriendlyTypeName", friendlyTypeName);

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}\\Content Type", null, contentType);

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}\\shell\\open\\command", null, $"{exePath} \"%1\"");

            
            return "Completed Succesfull";
        }
        public static string SetCustomFileHandler(string exePath, string fileExtension, string description, string friendlyTypeName, string contentType)
        {
            // Get the registry key for the file extension.
            RegistryKey extensionKey = Registry.ClassesRoot.OpenSubKey(fileExtension, RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Set the default value of the extension key to the description.
            extensionKey.SetValue(null, description);

            // Create a subkey for the extension key called "FriendlyTypeName".
            RegistryKey friendlyTypeNameKey = extensionKey.CreateSubKey("FriendlyTypeName");

            // Set the value of the "FriendlyTypeName" key to the friendly type name.
            friendlyTypeNameKey.SetValue(null, friendlyTypeName);

            // Create a subkey for the extension key called "Content Type".
            RegistryKey contentTypeKey = extensionKey.CreateSubKey("Content Type");

            // Set the value of the "Content Type" key to the content type.
            contentTypeKey.SetValue(null, contentType);

            // Create a subkey for the extension key called "shell".
            RegistryKey shellKey = extensionKey.CreateSubKey("shell");

            // Create a subkey for the "shell" key called "open".
            RegistryKey openKey = shellKey.CreateSubKey("open");

            // Create a subkey for the "open" key called "command".
            RegistryKey commandKey = openKey.CreateSubKey("command");

            // Set the value of the "command" key to the path of the executable file, followed by the command line arguments.
            commandKey.SetValue(null, $"{exePath} \"%1\"");

            Registry.SetValue($"HKEY_CLASSES_ROOT\\{fileExtension}\\shell\\open\\command", null, $"{exePath} \"%1\"");

            RegistryKey customVerbKey = Registry.CurrentUser.CreateSubKey($"SOFTWARE\\Classes\\{fileExtension}\\shell\\open");

            // Set the custom verb's description.
            customVerbKey.SetValue(null, "open");


            // Close all of the registry keys.
            extensionKey.Close();
            friendlyTypeNameKey.Close();
            contentTypeKey.Close();
            shellKey.Close();
            openKey.Close();
            commandKey.Close();

            // Return a message indicating that the operation was successful.
            return "Completed Succesfull";
        }

    }


}
