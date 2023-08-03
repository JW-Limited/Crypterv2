namespace LILO_Packager
{
    public static class Program
    {
        public static int DefaultEnvironment = 0;

        [STAThread]
        public static void Main(string[] args)
        {
            InitializeApplication();

            int startingEnvironment = GetStartingEnvironment(args);

            if (startingEnvironment == 1)
            {
                RunInstallPackage();
            }
            else
            {
                RunMainUI();
            }
        }

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        private static int GetStartingEnvironment(string[] args)
        {
            if (args.Length > 0 && int.TryParse(args[0], out int environment))
            {
                return environment;
            }

            return DefaultEnvironment;
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

