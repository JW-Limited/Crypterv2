using System.Runtime.InteropServices;

namespace LILO_Packager.v2.Core.Visuals
{
    public class WindowsFluentAPI
    {
        [DllImport("user32.dll", EntryPoint = "EnableMica", SetLastError = true)]
        public static extern bool EnableMica(bool enable);

    }
}
