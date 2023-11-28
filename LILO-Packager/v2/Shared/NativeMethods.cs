using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LILO_Packager.v2.Shared
{
    public static class NativeMethods
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(nint hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(nint hWnd, int nCmdShow);

        public const int SW_RESTORE = 9;

        public static class ProcessHelper
        {
            public static float GetProcessPercentage(int processId)
            {
                try
                {
                    Process process = Process.GetProcessById(processId);
                    long totalCpuTime = process.TotalProcessorTime.Ticks;
                    long elapsedTime = process.PrivilegedProcessorTime.Ticks;

                    if (totalCpuTime == 0)
                    {
                        return 0f;
                    }

                    return (float)elapsedTime / (float)totalCpuTime * 100f;
                }
                catch (Exception)
                {
                    return 0f;
                }
            }
        }

    }
}

