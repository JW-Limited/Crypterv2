using System.Diagnostics;
using LILO_Packager.v2;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Core.Boot;
using LILO_Packager.v2.Shared.Types;
using LILO_Packager.v2.Core.BugBarrier;
using LILO_Packager.v2.Core.Interfaces;

namespace LILO_Packager
{
    public static partial class Program
    {
        public static NotifyIcon noty;
        public static DependencyInjectionContainer InstanceCacheContainer = new DependencyInjectionContainer();
        public static string Version = "v0.11.1-beta";
        public static string CloudVersion = "0.9.2-preview";
        private static IBootManager _bootManager;

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            BugBarrier.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            InstanceCacheContainer.Register<IBootManager>(() => new BootManager());
            _bootManager = InstanceCacheContainer.Resolve<IBootManager>();

            try
            {
                Task.Run(() => Process.Start(@$"{Application.ExecutablePath.Replace("crypterv2.exe", "")}InstallHelper.exe", "--cp=" + Application.ExecutablePath));
                ConsoleManager.Instance().WriteLineWithColor("Started InstallHelper the Application is closing now meanwhile the Helper is doing his thing.", ConsoleColor.DarkGreen);
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor(ex.Message);
            }

            InstanceCacheContainer.Register<ILILOConsoleManager>(() => ConsoleManager.Instance());
        }

        [STAThread]
        public static void Main(string[] args)
        {
            InitializeApplication();

            if (config.Default.aggrementAccepted)
            {
                try
                {
                    if (args.Length > 0)
                    {
                        _bootManager.Run(args);
                    }
                    else
                    {
                        try
                        {
                            if (IsApplicationAlreadyRunning())
                            {
                                BringRunningInstanceToFront();
                                return;
                            }

                            RunMainUI();
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show("An Error Accoured: " + ex.Message, "Error - RunMainUi");
                            ConsoleManager.Instance().WriteLineWithColor("An Error Acourred: " + ex.Message, ConsoleColor.Red);
                        }
                    }
                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error - BootManager", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error, 
                                    MessageBoxDefaultButton.Button2, 
                                    MessageBoxOptions.ServiceNotification);
                }
            }
            else
            {
                RunAgrrement();
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

        private static void RunMainUI()
        {
            MainHost.Instance().AutoScaleMode = AutoScaleMode.Font;
            Application.AddMessageFilter(new AdvancedMessageFilter(MainHost.Instance()));
            Application.Run(MainHost.Instance());
        }

        private static void RunAgrrement()
        {
            Application.Run(v2.Forms.uiAgrement.Instance());
        }
    }
}

