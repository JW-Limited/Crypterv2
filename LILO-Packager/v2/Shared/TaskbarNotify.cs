using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared
{
    public class EventLogManager
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto, EntryPoint = "ReadEventLog")]
        static extern Boolean ReadEventLog(IntPtr hEventLog, EVT_READ_FLAGS dwReadFlags, UInt32 dwRecordOffset, IntPtr lpBuffer, UInt32 nNumberOfBytesToRead, out UInt32 pnBytesRead, out UInt32 pnMinNumberOfBytesNeeded);

        enum EVT_READ_FLAGS : uint
        {
            EVENTLOG_SEEK_READ = 0x0002,
            EVENTLOG_SEQUENTIAL_READ = 0x0001,
            EVENTLOG_FORWARDS_READ = 0x0004,
            EVENTLOG_BACKWARDS_READ = 0x0008
        }

        public static int ReadBlockOfRecords(IntPtr hEventLog, out IntPtr pBuff, UInt32 dwRecordNumber)

        {
            int status = 0;
            UInt32 dwBytesRead = 0;
            UInt32 dwMinBytes = 0;
            UInt32 dwBytesToRead = 524287;//max buffer size
            pBuff = Marshal.AllocHGlobal((int)dwBytesToRead);
            if (!ReadEventLog(hEventLog, EVT_READ_FLAGS.EVENTLOG_SEQUENTIAL_READ | EVT_READ_FLAGS.EVENTLOG_BACKWARDS_READ, dwRecordNumber, pBuff, dwBytesToRead, out dwBytesRead, out dwMinBytes))
            {
                status = Marshal.GetLastWin32Error();
                if (status == 122)
                {
                    pBuff = Marshal.ReAllocHGlobal(pBuff, (IntPtr)Convert.ToInt32(dwMinBytes));
                    dwBytesToRead = dwMinBytes;
                    if (!ReadEventLog(hEventLog, EVT_READ_FLAGS.EVENTLOG_SEQUENTIAL_READ | EVT_READ_FLAGS.EVENTLOG_BACKWARDS_READ, dwRecordNumber, pBuff, dwBytesToRead, out dwBytesRead, out dwMinBytes))
                    {
                        Console.WriteLine("ReadRecord (2) ERROR {0}", Marshal.GetLastWin32Error());
                    }
                    else
                    {
                        return Marshal.GetLastWin32Error();
                    }

                }
                else
                {
                    Console.WriteLine("ReadRecord ERROR {0}", Marshal.GetLastWin32Error());
                }
            }

            return (int)dwBytesRead;
        }
    }
}
