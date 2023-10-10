using System.Diagnostics;

namespace LILO_Packager.v2.Plugins.ThirdParty.Types;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public struct INSTALLER_CODES
{
    public static Int32 OLD_WIN_VERSION = 0x100000F5;
    public static Int32 SUCCESS = 0x000001D3;
    public static Int32 INSUFFICIENT_STORAGE = 0x000000E7;
    public static Int32 INVALID_INSTALL_PATH = 0x000000E8;
    public static Int32 INCOMPATIBLE_OS = 0x000000E9;
    public static Int32 MISSING_PREREQUISITES = 0x000000EA;
    public static Int32 INSTALLATION_FAILED = 0x000000EB;
    public static Int32 INVALID_PACKAGE = 0x000000EC;
    public static Int32 INVALID_INSTALLER = 0x000000ED;
    public static Int32 ACCESS_DENIED = 0x000000EE;
    public static Int32 MISSING_DEPENDENCIES = 0x000000EF;
    public static Int32 NETWORK_ERROR = 0x000000F0;
    public static Int32 INVALID_LICENSE_KEY = 0x000000F1;
    public static Int32 INVALID_INSTALL_METHOD = 0x000000F2;
    public static Int32 SYSTEM_REBOOT_REQUIRED = 0x000000F3;
    public static Int32 INSTALLER_TIMEOUT = 0x000000F4;
    public static Int32 UNSUPPORTED_ARCHITECTURE = 0x000000F6;
    public static Int32 MISSING_INSTALLER_FILE = 0x000000F7;
    public static Int32 INVALID_INSTALLER_VERSION = 0x000000F8;
    public static Int32 FILE_NOT_FOUND = 0x10070002;
    public static Int32 FILE_IN_USE = 0x10070020;
    public static Int32 INVALID_PARAMETER = 0x10070057;
    public static Int32 FILE_ACCESS_DENIED = 0x10070005;
    public static Int32 PATH_TOO_LONG = 0x100700CE;
    public static Int32 REGISTRY_ERROR = 0x100703F8;
    public static Int32 NOT_ENOUGH_MEMORY = 0x10070008;
    public static Int32 FILE_ALREADY_EXISTS = 0x10070050;
    public static Int32 DLL_NOT_FOUND = 0x1007007E;
    public static Int32 INVALID_HANDLE = 0x10070006;
    public static Int32 INVALID_OPERATION = 0x100703E3;
    public static Int32 DIRECTORY_NOT_EMPTY = 0x10070091;
    public static Int32 DEVICE_NOT_CONNECTED = 0x10070426;
    public static Int32 SERVICE_START_FAILED = 0x1007042C;
    public static Int32 OUT_OF_RESOURCES = 0x1007000E;
    public static Int32 TIMEOUT_EXPIRED = 0x100705B4;
    public static Int32 FILE_READ_ONLY = 0x100710D2;
    public static Int32 INVALID_CONFIGURATION = 0x10070057;
    public static Int32 BUFFER_OVERFLOW = 0x10070050;
    public static Int32 INVALID_DATA = 0x1007000D;

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}