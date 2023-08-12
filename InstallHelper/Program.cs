using Microsoft.Win32;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;


namespace InstallHelper
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("--cp="))
                    {
                        Console.WriteLine(args[i].Substring(5));
                        SetCustomFileHandlerAsync(args[i].Substring(5));
                        Console.ReadKey();
                    }
                }

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