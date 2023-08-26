using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Authentication
{
    public class ChromeWrapper
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);  
        private static uint WM_KEYDOWN = 0x100, WM_KEYUP = 0x101;
        private Process chromeProcess;

        public ChromeWrapper()
        {
        }
        public void SendKey(char key, Process process_chrome)
        {
            try
            {
                if (process_chrome.MainWindowHandle != IntPtr.Zero)
                {                   
                    SendMessage(process_chrome.MainWindowHandle, ChromeWrapper.WM_KEYDOWN, (IntPtr)key, IntPtr.Zero);                  
                    Thread.Sleep(30); 
                    SendMessage(process_chrome.MainWindowHandle, ChromeWrapper.WM_KEYUP, (IntPtr)key, IntPtr.Zero);
                }
            }
            catch (Exception e) 
            {
            }
        }
    }
}
