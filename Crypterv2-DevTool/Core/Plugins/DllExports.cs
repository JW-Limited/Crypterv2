using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Crypterv2.DevTool.Core.Plugins
{
    public static class DllExports
    {
        public static unsafe PEHeader GetPEHeader(string dllPath)
        {
            var dllHandle = DllExports.LoadLibraryEx(dllPath, IntPtr.Zero, 0);

            PEHeader peHeader;
            if (!DllExports.GetModuleInformation(dllHandle, IntPtr.Zero, out peHeader, sizeof(PEHeader)))
            {
                throw new Exception("Failed to get the PE header of the DLL library.");
            }

            return peHeader;
        }

        public static unsafe string GetImportDllName(IMAGE_IMPORT_DESCRIPTOR importEntry)
        {
            var dllNamePtr = (IntPtr)(importEntry.Name);
            string dllName = Marshal.PtrToStringAnsi(dllNamePtr);

            return dllName;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, int dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetModuleInformation(IntPtr hModule, IntPtr lpBuffer, out PEHeader lpPeb, int cbSize);
    }

}
