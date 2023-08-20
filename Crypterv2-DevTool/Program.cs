using System.Diagnostics;

namespace Crypterv2_DevTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        [STAThread]
        static void Main()
        {
            InitializeApplication();

            if(Process.GetProcessesByName("crypterv2").Length < 1)
            {
                MessageBox.Show("Please start the Crypterv2 Application befor using this tool.","Mainhost",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
                return;
            }

            Application.Run(new Main());
        }
    }
}