using InstallHelper.Core;
using System.Diagnostics;
using System.IO;

namespace InstallHelper
{
    public static class Program
    {
        public static string _uninstallString;

        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("--cp="))
                    {
                        var path = args[i].Substring(5);

                        Console.WriteLine("Setup started: v1.0.2.29083");

                        KillCrypter();

                        RegistryEntries(path);
                        ShortCutRegistrations(path);
                        RegisterProduct(path);
                        DisableTrailBreaker();
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

        public static void DisableTrailBreaker()
        {
            Console.Write("Disabling TrailBraker: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{TrailBraker.Disable()}\n");
            Console.ResetColor();
        }

        public static void RegistryEntries(string path)
        {
            Console.Write("Updating Registry: ");
            ExtensionBinder.SetCustomFileHandlerAsync(path);
            ExtensionBinder.RegisterContextMenuEntry(path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Done!\n");
            Console.ResetColor();
        }

        public static void ShortCutRegistrations(string path)
        {
            Console.Write("Creating Shortcuts: ");
            ShortcutOperations.CreateDesktopShortcut(path);
            ShortcutOperations.CreateStartMenuShortcut(path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Done!\n");
            Console.ResetColor();
        }

        public static void RegisterProduct(string path)
        {
            Console.Write("Register Product: ");
            ProductRegistration.RegisterProduct("Crypterv2 - Professional", "2.0.0.0", AppDomain.CurrentDomain.BaseDirectory + "\\crypterv2.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Done!\n ");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void KillCrypter()
        {
            var processName = "crypterv2";

            if (Process.GetProcessesByName(processName).Length > 0)
            {
                foreach (var proc in Process.GetProcessesByName(processName))
                {
                    proc.Kill();
                }
            }

            Console.WriteLine("\nKilled all instances of: crypterv2");
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
                    Uninstall.Start();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
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
    }
}
    
