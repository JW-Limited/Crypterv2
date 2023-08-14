using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;
using Microsoft.Win32;
using System.Diagnostics;
using Microsoft.FeatureManagement;

namespace LILO_Packager
{
    public static class Program
    {
        public static int DefaultEnvironment = 0;

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        [STAThread]
        public static void Main(string[] args)
        {
            InitializeApplication();

            try
            {

                Process.Start(@$"{Application.ExecutablePath.Replace("crypterv2.exe", "")}InstallHelper.exe", "--cp=" + Application.ExecutablePath);
            }

            catch(Exception ex)
            {
                
            }

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (!File.Exists(args[i])) return;

                    if (args[i].EndsWith(".lsf"))
                    {
                        EncryptedFile file = new EncryptedFile(args[i]);
                        var decrypt = uiArgumentStart.Instance(file);
                        Application.Run(decrypt);
                    }
                    else 
                    {
                        DecryptedFile file = new DecryptedFile(args[i]);
                        var encrypt = uiArgumentStart_Encrypt.Instance(file);
                        Application.Run(encrypt);
                    }
                }

            }
            else
            {
                RunMainUI();
            }

            
        }


        private static void RunMainUI()
        {
            Application.Run(v2.MainHost.Instance());
        }

        private static void RunInstallPackage()
        {
            Application.Run(new InstallPackage());
        }
    }
}

