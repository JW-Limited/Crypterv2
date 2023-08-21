using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;
using Microsoft.Win32;
using System.Diagnostics;
using Microsoft.FeatureManagement;
using System.Runtime.InteropServices;
using System.Threading;

namespace LILO_Packager
{
    public static class Program
    {
        public static int DefaultEnvironment = 0;
        public static NotifyIcon noty;

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }

        public static Mutex myMutex = new Mutex(false, "crypter_v2");

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

                if (IsApplicationAlreadyRunning())
                {
                    BringRunningInstanceToFront();
                    return;
                }


                RunMainUI();
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
                if (process.Id != currentProcess.Id)
                {
                    IntPtr hWnd = process.MainWindowHandle;
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


        private static void RunMainUI()
        {
            v2.MainHost.Instance().AutoScaleMode = AutoScaleMode.Font;
            Application.Run(v2.MainHost.Instance());
        }

        private static void RunInstallPackage()
        {
            Application.Run(new InstallPackage());
        }
    }
}

