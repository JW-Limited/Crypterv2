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
    public class AdvancedMessageFilter : IMessageFilter
    {
        private const int WM_CUSTOM_MESSAGE = 0x8000;
        private const int WM_CUSTOM_ACTION = 0x8001;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_CUSTOM_MOUSE_CLICK = 0x8002;
        private const int WM_CUSTOM_MOUSE_DOUBLE_CLICK = 0x8003;
        private const int WM_CLIPBOARD_UPDATE = 0x031D;

        private readonly Form targetForm;

        private List<string> customMessages = new List<string>();

        public AdvancedMessageFilter(Form form)
        {
            targetForm = form;

            targetForm.Activated += (sender, e) =>
            {
                Console.WriteLine("Form Regained Focus");
                Message message = Message.Create(targetForm.Handle, 0x0008, IntPtr.Zero, IntPtr.Zero);
                Console.WriteLine($"Additional Info - WPARAM: {message.WParam}, LPARAM: {message.LParam}");
            };


        }

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_MOUSEMOVE:
                    int xPos = (int)(short)m.LParam;
                    int yPos = (int)(short)(m.LParam >> 16);
                    Console.WriteLine($"Mouse Move: X={xPos}, Y={yPos}");
                    break;

                case WM_MOUSEWHEEL:
                    int delta = (int)(short)(m.WParam >> 16);
                    Console.WriteLine($"Mouse Wheel: Delta={delta}");
                    break;

                case WM_KEYDOWN:
                    Keys keyData = (Keys)(int)m.WParam;
                    Console.WriteLine($"Key Down: {keyData}");
                    break;

                case WM_KEYUP:
                    Keys keyUpData = (Keys)(int)m.WParam;
                    Console.WriteLine($"Key Up: {keyUpData}");
                    break;

                case WM_CUSTOM_MESSAGE:
                    customMessages.Add("Custom Message Received");
                    Console.WriteLine("Custom Message Received");
                    break;

                case WM_CUSTOM_ACTION:
                    Console.WriteLine("Custom Action Performed");
                    break;

                case WM_CUSTOM_MOUSE_CLICK:
                    Console.WriteLine("Custom Mouse Click");
                    break;

                case WM_CUSTOM_MOUSE_DOUBLE_CLICK:
                    Console.WriteLine("Custom Mouse Double-Click");
                    break;

                case WM_CLIPBOARD_UPDATE:
                    Console.WriteLine("Clipboard Updated");
                    break;

                default:
                    break;
            }

            return false;
        }

        public List<string> GetCustomMessages()
        {
            return customMessages;
        }
    }

    public static class Program
    {
        public static int DefaultEnvironment = 0;
        public static NotifyIcon noty;
        public static string Version = "v0.9.3-beta";

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

