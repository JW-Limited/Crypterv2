using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static LILO_Packager.v2.Shared.Streaming.Core.FileStreamObserver;

namespace LILO_Packager.v2.Shared.Streaming.Core
{
    public class FileStreamObserver
    {
        public unsafe static void ObserveFileStream(FileStream filestream)
        {
            IntPtr handle = filestream.SafeFileHandle.DangerousGetHandle();
            const int bufferSize = 4096; // Adjust the buffer size as needed
            IntPtr buffer = Marshal.AllocHGlobal(bufferSize); // Allocate memory for the buffer

            try
            {
                FILE_NOTIFY_INFORMATION notificationInfo = new FILE_NOTIFY_INFORMATION();

                Console.WriteLine("Now Observing Filestream");

                while (true)
                {
                    bool success = NativeMethods.ReadDirectoryChangesW(handle, notificationInfo, (uint)bufferSize, false);

                    if (success)
                    {
                        // Cast the pointer to FILE_NOTIFY_INFORMATION
                        notificationInfo = Marshal.PtrToStructure<FILE_NOTIFY_INFORMATION>(buffer);

                        FILE_ACTION action = (FILE_ACTION)notificationInfo.dwAction;
                        string fileName = notificationInfo.FileName;

                        switch (action)
                        {
                            case FILE_ACTION.FILE_ACTION_ADDED:
                                Console.WriteLine($"File added: {fileName}");
                                break;
                            case FILE_ACTION.FILE_ACTION_REMOVED:
                                Console.WriteLine($"File removed: {fileName}");
                                break;
                            case FILE_ACTION.FILE_ACTION_MODIFIED:
                                Console.WriteLine($"File modified: {fileName}");
                                break;
                            case FILE_ACTION.FILE_ACTION_RENAMED_OLD_NAME:
                                Console.WriteLine($"File renamed (old name): {fileName}");
                                break;
                            case FILE_ACTION.FILE_ACTION_RENAMED_NEW_NAME:
                                Console.WriteLine($"File renamed (new name): {fileName}");
                                break;
                            default:
                                Console.WriteLine($"Unknown file action: {action}, File: {fileName}");
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            finally
            {
                // Release allocated memory
                Marshal.FreeHGlobal(buffer);
            }
        }

        public const uint INFINITE = 0xFFFFFFFF;

        public const uint WAIT_OBJECT_0 = 0x00000000;

        public const int FILE_ACTION_MODIFIED = 0x0002;

        public enum FILE_ACTION : uint
        {
            FILE_ACTION_ADDED = 0x00000001,
            FILE_ACTION_REMOVED = 0x00000002,
            FILE_ACTION_MODIFIED = 0x00000003,
            FILE_ACTION_RENAMED_OLD_NAME = 0x00000004,
            FILE_ACTION_RENAMED_NEW_NAME = 0x00000005
        }


        public class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool ReadDirectoryChangesW(IntPtr hDirectory, [Out] FILE_NOTIFY_INFORMATION lpBuffer, uint nNumberOfBytesToWrite, bool bWatchSubtree);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);
        }

        public struct FILE_NOTIFY_INFORMATION
        {
            public uint dwAction;
            public uint dwFilter;
            public uint dwFileSize;
            public uint dwFileAttributes;
            public uint dwFileNameLength;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string FileName;
        }


        public enum FILE_NOTIFY_FILTER
        {
            FILE_NOTIFY_CHANGE_FILE_NAME = 1,
            FILE_NOTIFY_CHANGE_DIR_NAME = 2,
            FILE_NOTIFY_CHANGE_ATTRIBUTES = 4,
            FILE_NOTIFY_CHANGE_SIZE = 8,
            FILE_NOTIFY_CHANGE_LAST_WRITE_TIME = 16,
            FILE_NOTIFY_CHANGE_SECURITY = 32,
            FILE_NOTIFY_CHANGE_CREATION = 64,
            FILE_NOTIFY_CHANGE_EA = 128,
            FILE_NOTIFY_CHANGE_LAST_ACCESS_TIME = 256,
            FILE_NOTIFY_CHANGE_CREATION_TIME = 512,
            FILE_NOTIFY_CHANGE_END_OF_DIRECTORY = 65536,
            FILE_NOTIFY_CHANGE_STREAM_NAME = 131072,
            FILE_NOTIFY_CHANGE_STREAM_SIZE = 262144,
            FILE_NOTIFY_CHANGE_STREAM_ATTRIBUTES = 524288,
            FILE_NOTIFY_CHANGE_STREAM_WRITE_TIME = 1048576,
            FILE_NOTIFY_CHANGE_STREAM_SECURITY = 2097152,
            FILE_NOTIFY_CHANGE_STREAM_CREATION = 4194304,
            FILE_NOTIFY_CHANGE_STREAM_END_OF_DIRECTORY = 8388608,
            FILE_NOTIFY_CHANGE_STREAM_LAST_ACCESS_TIME = 16777216,
            FILE_NOTIFY_CHANGE_STREAM_CREATION_TIME = 33554432,
            FILE_NOTIFY_CHANGE_ALL = -1
        }

    }
}
