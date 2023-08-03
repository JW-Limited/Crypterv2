using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;

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

            (var file, int startingEnvironment) = GetStartingMode(args);

            if (startingEnvironment == 1)
            {
                var decrypt = uiArgumentStart.Instance(file);
                Application.Run(decrypt);
            }
            else
            {
                RunMainUI();
            }
        }

        

        private static (EncryptedFile,int) GetStartingMode(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (File.Exists(args[i]))
                    {
                        EncryptedFile env = new EncryptedFile(args[i]);
                        return (env, 1);
                    }
                }

                return (null, 0);
            }

            return (null, 0);
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

