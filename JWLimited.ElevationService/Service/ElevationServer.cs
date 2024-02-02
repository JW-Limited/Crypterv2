using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System;
namespace JWLimited.ElevationService.Service
{

    public class ElevationServer
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool OpenProcessToken(nint processHandle, uint desiredAccess, out nint tokenHandle);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool CreateProcessAsUser(
            nint tokenHandle,
            string applicationName,
            string commandLine,
            ref SECURITY_ATTRIBUTES processAttributes,
            ref SECURITY_ATTRIBUTES threadAttributes,
            bool inheritHandles,
            uint creationFlags,
            nint environment,
            string currentDirectory,
            ref STARTUPINFO startupInfo,
            out PROCESS_INFORMATION processInformation);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint WaitForSingleObject(nint hHandle, uint dwMilliseconds);

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public nint hProcess;
            public nint hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public uint nLength;
            public nint lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public nint lpReserved2;
            public nint hStdInput;
            public nint hStdOutput;
            public nint hStdError;
        }

        [DllImport("kernel32.dll")]
        public static extern nint GetCurrentProcess();

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateTokenEx(
            nint hExistingToken,
            uint dwDesiredAccess,
            ref SECURITY_ATTRIBUTES lpThreadAttributes,
            uint ImpersonationLevel,
            uint dwTokenType,
            ref nint phNewToken);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(nint hObject);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetTokenInformation(
            nint TokenHandle,
            uint TokenInformationClass,
            nint TokenInformation,
            uint TokenInformationLength);

        public const uint TOKEN_DUPLICATE = 0x0002;
        public const uint TOKEN_ASSIGN_PRIMARY = 0x0001;
        public const uint TOKEN_ALL_ACCESS = 0xF01FF;
        public const uint CREATE_UNICODE_ENVIRONMENT = 0x00000400;
        public const uint STARTF_USESHOWWINDOW = 0x00000001;
        public const uint STARTF_FORCEONFEEDBACK = 0x00000040;
        public const uint CREATE_NEW_CONSOLE = 0x00000010;
        public const uint CREATE_NEW_PROCESS_GROUP = 0x00000200;
        public const uint CREATE_NO_WINDOW = 0x08000000;
        public const uint WAIT_FAILED = 0xFFFFFFFF;

        public enum SECURITY_IMPERSONATION_LEVEL : uint
        {
            SecurityAnonymous = 0,
            SecurityIdentification = 1,
            SecurityImpersonation = 2,
            SecurityDelegation = 3
        }

        public enum TOKEN_TYPE : uint
        {
            TokenPrimary = 1,
            TokenImpersonation = 2
        }

        

        private static ILogger _logger;

        public static void Main()
        {
            _logger = new Logger(".\\access.log",LogLevel.Information);
            StartServer();
        }

        public static bool SetTokenInformationInternal(
                nint TokenHandle,
                uint TokenInformationClass,
                nint TokenInformation,
                uint TokenInformationLength)
        {
            if (TokenHandle == nint.Zero)
            {
                _logger.LogError("Token handle is invalid.");
                return false;
            }

            try
            {
                bool result = SetTokenInformation(TokenHandle, TokenInformationClass, TokenInformation, TokenInformationLength);

                if (!result)
                {
                    int lastError = Marshal.GetLastWin32Error();
                    _logger.LogError($"Error setting token information. Error code: {lastError}");
                }
                else
                {
                    _logger.LogInformation("Token information set successfully.");
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception setting token information: {ex.Message}");
                return false;
            }
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AdjustTokenPrivileges(
            nint TokenHandle,
            [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges,
            ref TOKEN_PRIVILEGES NewState,
            uint BufferLength,
            ref TOKEN_PRIVILEGES PreviousState,
            ref uint ReturnLength);

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        private struct TOKEN_PRIVILEGES
        {
            public uint PrivilegeCount;
            public LUID Luid;
            public uint Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct LUID
        {
            public uint LowPart;
            public int HighPart;
        }

        private static bool EnablePrivilege(nint tokenHandle, string privilegeName)
        {
            try
            {
                TOKEN_PRIVILEGES tp = new TOKEN_PRIVILEGES
                {
                    PrivilegeCount = 1,
                    Attributes = 2 // SE_PRIVILEGE_ENABLED
                };

                if (!LookupPrivilegeValue(null, privilegeName, out tp.Luid))
                {
                    _logger.LogError($"LookupPrivilegeValue failed. Error code: {Marshal.GetLastWin32Error()}");
                    return false;
                }

                uint returnLength = 0;

                if (!AdjustTokenPrivileges(tokenHandle, false, ref tp, (uint)Marshal.SizeOf(typeof(TOKEN_PRIVILEGES)), ref tp, ref returnLength))
                {
                    int lastError = Marshal.GetLastWin32Error();
                    _logger.LogError($"AdjustTokenPrivileges failed. Error code: {lastError}");
                    _logger.LogError($"Buffer size: {Marshal.SizeOf(typeof(TOKEN_PRIVILEGES))}");
                    return false;   
                }

                //if (Marshal.GetLastWin32Error() != 0)
                //{
                //    _logger.LogError($"AdjustTokenPrivileges returned a non-zero error code. " + Marshal.GetLastWin32Error());
                //    return false;
                //}

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception enabling privilege: {ex.Message}");
                return false;
            }
        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool LookupPrivilegeValue(
            string lpSystemName,
            string lpName,
            out LUID lpLuid);


        static void StartServer()
        {
            int port = 9457; 
            TcpListener server = null;

            try
            {
                // Initialisiere den Server
                server = new TcpListener(IPAddress.Any, port);
                server.Start();

                _logger.Log(LogLevel.Information,$"Server gestartet, lauscht auf Port {port}");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    _logger.LogInformation("Client verbunden");

                    ProcessClient(client);
                }
            }
            catch (Exception ex)
            {
               _logger.LogCritical($"Fehler: {ex.Message}");
            }
            finally
            {
                server?.Stop();
            }
        }

        static void ProcessClient(TcpClient client)
        {
            // Lese die Daten vom Client
            using (NetworkStream stream = client.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string jsonData = reader.ReadToEnd();

                // Deserialisiere die Daten in eine ApplicationPrefix-Instanz
                ApplicationPrefix appPrefix = JsonConvert.DeserializeObject<ApplicationPrefix>(jsonData);

                // Starte die Anwendung mit erhöhten Rechten
                StartApplicationWithElevatedPrivileges(appPrefix);
            }
        }

        static void StartApplicationWithElevatedPrivileges(ApplicationPrefix appPrefix)
        {
            nint currentProcessToken = nint.Zero;
            nint duplicateToken = nint.Zero;

            try
            {
                // Öffne den Token des aktuellen Prozesses
                _logger.Log(LogLevel.Information, "Attempting to open process token");
                if (!OpenProcessToken(GetCurrentProcess(), TOKEN_DUPLICATE, out currentProcessToken))
                {
                    _logger.LogError($"Error opening process token. Error code: {Marshal.GetLastWin32Error()}");
                    throw new ApplicationException("Fehler beim Öffnen des Prozess-Tokens.");
                }

                SECURITY_ATTRIBUTES sa = new SECURITY_ATTRIBUTES();
                sa.nLength = (uint)Marshal.SizeOf(typeof(SECURITY_ATTRIBUTES));

                _logger.Log(LogLevel.Information, "Attempting to duplicate token");
                if (!DuplicateTokenEx(
                    currentProcessToken,
                    TOKEN_ALL_ACCESS,
                    ref sa,
                    (uint)SECURITY_IMPERSONATION_LEVEL.SecurityIdentification,
                    (uint)TOKEN_TYPE.TokenPrimary,
                    ref duplicateToken))
                {
                    _logger.LogError($"Error duplicating token. Error code: {Marshal.GetLastWin32Error()}");
                    throw new ApplicationException("Fehler beim Duplizieren des Tokens.");
                }

                if (!EnablePrivilege(duplicateToken, "SeIncreaseQuotaPrivilege"))
                {
                    throw new ApplicationException("Error enabling SeIncreaseQuotaPrivilege.");
                }

                _logger.Log(LogLevel.Information, "Attempting to set token information");
                if (!SetTokenInformationInternal(duplicateToken, 18, nint.Zero, 0))
                {
                    _logger.LogError($"Error setting token information. Error code: {Marshal.GetLastWin32Error()}");
                    throw new ApplicationException("Fehler beim Setzen der Tokeninformation.");
                }

                STARTUPINFO startupInfo = new STARTUPINFO();
                startupInfo.cb = (uint)Marshal.SizeOf(typeof(STARTUPINFO));

                PROCESS_INFORMATION processInfo = new PROCESS_INFORMATION();

                _logger.Log(LogLevel.Information, "Attempting to create process as user");
                if (!CreateProcessAsUser(
                    duplicateToken,
                    appPrefix.ApplicationName,
                    string.Join(" ", appPrefix.StartArguments),
                    ref sa,
                    ref sa,
                    false,
                    CREATE_NEW_CONSOLE,
                    nint.Zero,
                    null,
                    ref startupInfo,
                    out processInfo))
                {
                    _logger.LogError($"Error creating process as user. Error code: {Marshal.GetLastWin32Error()}");
                    throw new ApplicationException($"Fehler beim Starten der Anwendung: {Marshal.GetLastWin32Error()}");
                }

                // Warte auf das Ende des gestarteten Prozesses
                WaitForSingleObject(processInfo.hProcess, 0xFFFFFFFF);
            }
            finally
            {
                // Schließe die geöffneten Handles
                if (currentProcessToken != nint.Zero)
                    CloseHandle(currentProcessToken);

                if (duplicateToken != nint.Zero)
                    CloseHandle(duplicateToken);
            }
        }
    }

}
