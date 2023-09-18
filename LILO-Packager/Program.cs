using LILO_Packager.v2;
using LILO_Packager.v2.Core.Boot;
using LILO_Packager.v2.Core.Debug;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace LILO_Packager
{
    public static class Program
    {
        public static int DefaultEnvironment = 0;
        public static NotifyIcon noty;
        public static string Version = "v0.9.5-beta";

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            ErrorCatcher.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        public static Mutex myMutex = new Mutex(false, "crypter_v2");

        [STAThread]
        public static void Main(string[] args)
        {
            InitializeApplication();
            
            //uiSplashScreen.Instance.ShowDialog();

            try
            {
                Process.Start(@$"{Application.ExecutablePath.Replace("crypterv2.exe", "")}InstallHelper.exe", "--cp=" + Application.ExecutablePath);
                ConsoleManager.Instance().WriteLineWithColor("Started InstallHelper the Application is closing now meanwhile the Helper is doing his thing.", ConsoleColor.DarkGreen);
            }

            catch(Exception ex)
            {
                
            }

            try
            {

                if (args.Length > 0)
                {
                    var bootManager = new BootManager();
                    bootManager.AnalyzeArguments(args);
                }
                else
                {

                    if (IsApplicationAlreadyRunning())
                    {
                        BringRunningInstanceToFront();
                        return;
                    }

                    try
                    {
                        if (config.Default.aggrementAccepted)
                        {
                            RunMainUI();
                        }
                        else
                        {
                            RunAgrrement();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error Accoured: " + ex.Message,"Error - RunMainUi");
                        ConsoleManager.Instance().WriteLineWithColor("An Error Acourred: " + ex.Message, ConsoleColor.Red);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - BootManager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            }


        }
        private static bool IsApplicationAlreadyRunning()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(currentProcess.ProcessName);

            var otherProcesses = processes.Where(p => p.Id != currentProcess.Id);

            return otherProcesses.Any();
        }

        private static void BringRunningInstanceToFront()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(currentProcess.ProcessName);

            foreach (var process in processes)
            {
                /// Set the foreground window to the current process.
                if (process.Id != currentProcess.Id)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    /// Set the foreground window to the given window.
                    if (hWnd != IntPtr.Zero)
                    {
                        NativeMethods.SetForegroundWindow(hWnd);
                        NativeMethods.ShowWindow(hWnd, NativeMethods.SW_RESTORE);
                    }
                }
            }

            Environment.Exit(0);
        }

        private static class NativeMethods
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            public const int SW_RESTORE = 9;
        }


        /// @brief Runs the V2 UI. This is called when the user clicks the Main UI
        private static void RunMainUI()
        {
            v2.MainHost.Instance().AutoScaleMode = AutoScaleMode.Font;
            Application.AddMessageFilter(new AdvancedMessageFilter(v2.MainHost.Instance()));
            Application.Run(v2.MainHost.Instance());
        }

        private static void RunAgrrement()
        {
            Application.Run(v2.Forms.uiAgrement.Instance());
        }

        private static void RunInstallPackage()
        {
            Application.Run(new InstallPackage());
        }
    }
}

