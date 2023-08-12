using InstallHelper.Core;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using IWshRuntimeLibrary;
using Microsoft.Win32;

namespace InstallHelper
{
    public static class Program
    {
        public static string _uninstallString;

        [STAThread]
        public static void Main(string[] args)
        {
            var processName = "crypterv2";

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("--cp="))
                    {
                        var path = args[i].Substring(5);

                        Console.WriteLine("Setup started: v0.2");
                        
                        if(Process.GetProcessesByName(processName).Length > 0)
                        {
                            foreach(var proc in Process.GetProcessesByName(processName))
                            {
                                proc.Kill();
                            }
                        }

                        Console.WriteLine("\nKilled all instances of: crypterv2");

                        Console.Write("Updating Registry: ");
                        SetCustomFileHandlerAsync(path);
                        RegisterContextMenuEntry(path);
                        Console.Write("Done!\n");

                        Console.Write("Creating Shortcuts: ");

                        ShortcutOperations.CreateDesktopShortcut(path);
                        ShortcutOperations.CreateStartMenuShortcut(path);

                        Console.Write("Done!\n");

                        Console.ReadKey();
                    }
                }

            }
            else
            {
                Console.WriteLine("Welcome to the Uninstaller!");

                DisplayOptions();

                int choice = GetChoiceFromUser();
                ProcessUserChoice(choice);
            }
        }

        public static void DisplayOptions()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Uninstall Application");
        }

        public static void ProcessUserChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    UninstallApplication();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public static void UninstallApplication()
        {
            
        }

        public static int GetChoiceFromUser()
        {
            int choice;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                    return choice;
                Console.WriteLine("Invalid input. Enter a valid choice.");
            }
        }

        

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