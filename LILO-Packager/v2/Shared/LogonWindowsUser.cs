using System.Net.Security;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace LILO_Packager.v2.Shared
{
    public class LogonWindowsUser
    {
        [DllImport("advapi32.dll", SetLastError = true, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool LogonUser(
                                              [MarshalAs(UnmanagedType.LPStr)] string pszUserName,
                                              [MarshalAs(UnmanagedType.LPStr)] string pszDomain,
                                              [MarshalAs(UnmanagedType.LPStr)] string pszPassword,
                                              int dwLogonType,
                                              int dwLogonProvider,
                                              ref IntPtr phToken);

        public enum LogonType
        {
            /// <summary>
            /// This logon type is intended for users who will be interactively using the computer, such as a user being logged on  
            /// by a terminal server, remote shell, or similar process.
            /// This logon type has the additional expense of caching logon information for disconnected operations;
            /// therefore, it is inappropriate for some client/server applications,
            /// such as a mail server.
            /// </summary>
            LOGON32_LOGON_INTERACTIVE = 2,

            /// <summary>
            /// This logon type is intended for high performance servers to authenticate plaintext passwords.

            /// The LogonUser function does not cache credentials for this logon type.
            /// </summary>
            LOGON32_LOGON_NETWORK = 3,

            /// <summary>
            /// This logon type is intended for batch servers, where processes may be executing on behalf of a user without
            /// their direct intervention. This type is also for higher performance servers that process many plaintext
            /// authentication attempts at a time, such as mail or Web servers.
            /// The LogonUser function does not cache credentials for this logon type.
            /// </summary>
            LOGON32_LOGON_BATCH = 4,

            /// <summary>
            /// Indicates a service-type logon. The account provided must have the service privilege enabled.
            /// </summary>
            LOGON32_LOGON_SERVICE = 5,

            /// <summary>
            /// This logon type is for GINA DLLs that log on users who will be interactively using the computer.
            /// This logon type can generate a unique audit record that shows when the workstation was unlocked.
            /// </summary>
            LOGON32_LOGON_UNLOCK = 7,

            /// <summary>
            /// This logon type preserves the name and password in the authentication package, which allows the server to make
            /// connections to other network servers while impersonating the client. A server can accept plaintext credentials
            /// from a client, call LogonUser, verify that the user can access the system across the network, and still
            /// communicate with other servers.
            /// NOTE: Collections NT:  This value is not supported.
            /// </summary>
            LOGON32_LOGON_NETWORK_CLEARTEXT = 8,

            /// <summary>
            /// This logon type allows the caller to clone its current token and specify new credentials for outbound connections.
            /// The new logon session has the same local identifier but uses different credentials for other network connections.
            /// NOTE: This logon type is supported only by the LOGON32_PROVIDER_WINNT50 logon provider.
            /// NOTE: Collections NT:  This value is not supported.
            /// </summary>
            LOGON32_LOGON_NEW_CREDENTIALS = 9,
        }

        public enum LogonProvider
        {
            /// <summary>
            /// Use the standard logon provider for the system.
            /// The default security provider is negotiate, unless you pass NULL for the domain name and the user name
            /// is not in UPN format. In this case, the default provider is NTLM.
            /// NOTE: Collections 2000/NT:   The default security provider is NTLM.
            /// </summary>
            LOGON32_PROVIDER_DEFAULT = 0,
            LOGON32_PROVIDER_WINNT35 = 1,
            LOGON32_PROVIDER_WINNT40 = 2,
            LOGON32_PROVIDER_WINNT50 = 3
        }

        public static WindowsIdentity LogonUserTCPListen(string userName, string domain, string password)
        {
            // need a full duplex stream - loopback is easiest way to get that
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 0);
            tcpListener.Start();
            ManualResetEvent done = new ManualResetEvent(false);

            WindowsIdentity id = null;
            tcpListener.BeginAcceptTcpClient(delegate (IAsyncResult asyncResult)
            {
                try
                {
                    using (NegotiateStream serverSide = new NegotiateStream(
                         tcpListener.EndAcceptTcpClient(asyncResult).GetStream()))
                    {
                        serverSide.AuthenticateAsServer(CredentialCache.DefaultNetworkCredentials,
                             ProtectionLevel.None, TokenImpersonationLevel.Impersonation);
                        id = (WindowsIdentity)serverSide.RemoteIdentity;
                    }
                }
                catch
                { id = null; }
                finally
                { done.Set(); }
            }, null);

            using (NegotiateStream clientSide = new NegotiateStream(new TcpClient("localhost",
                 ((IPEndPoint)tcpListener.LocalEndpoint).Port).GetStream()))
            {
                try
                {
                    clientSide.AuthenticateAsClient(new NetworkCredential(userName, password, domain),
                     "", ProtectionLevel.None, TokenImpersonationLevel.Impersonation);
                }
                catch
                { id = null; }
            }
            tcpListener.Stop();
            done.WaitOne();
            return id;
        }
    }
}
