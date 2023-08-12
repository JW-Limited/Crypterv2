using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace InstallHelper.Core
{
    public class ShortcutOperations
    {
        public static void CreateStartMenuShortcut(string path)
        {
            string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Crypterv2.lnk");
            CreateShortcut(shortcutPath, path, "Crypterv2 - Encrypt Files");
        }

        public static void CreateDesktopShortcut(string path)
        {
            string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Crypterv2.lnk");
            CreateShortcut(shortcutPath, path, "Crypterv2 - Encrypt Files");
        }

        public static void CreateShortcut(string shortcutPath, string targetPath, string description)
        {
            IWshRuntimeLibrary.WshShell wshShell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wshShell.CreateShortcut(shortcutPath) as IWshRuntimeLibrary.IWshShortcut;

            shortcut.TargetPath = targetPath;
            shortcut.Description = description;
            shortcut.Save();
        }
    }
}
