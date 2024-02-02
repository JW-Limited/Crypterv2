using JWLimited.ElevationService.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;

namespace LILO_Packager.v2.Core.Boot
{
    public class TaskManager
    {
        private string serverAddress = "127.0.0.1";
        private int serverPort = 9457;
        private List<int> runningTasks = new List<int>();

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern IntPtr OpenSCManager(string machineName, string databaseName, uint desiredAccess);

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern IntPtr OpenService(IntPtr hSCManager, string serviceName, uint desiredAccess);

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool StartService(IntPtr hService, uint dwNumServiceArgs, string[] lpServiceArgVectors);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseServiceHandle(IntPtr hSCObject);

        public void StartTaskAsAdmin(string applicationPath, string[] startArguments)
        {
            CheckAndStartElevationService();

            try
            {
                var appPrefix = new ApplicationPrefix
                {
                    ApplicationName = applicationPath,
                    StartArguments = startArguments
                };

                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(appPrefix);

                using (TcpClient client = new TcpClient(serverAddress, serverPort))
                using (NetworkStream stream = client.GetStream())
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(jsonData);
                    writer.Flush();
                }

                int processId = WaitForTaskToStart(new FileInfo(applicationPath).Name);
                runningTasks.Add(processId);

                Console.WriteLine($"Task started with Process ID: {processId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Starten der Aufgabe: {ex.Message}");
            }
        }

        public void CloseTask(int processId)
        {
            try
            {
                Process.GetProcessById(processId).Kill();
                runningTasks.Remove(processId);
                Console.WriteLine($"Task with Process ID {processId} closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Schließen der Aufgabe: {ex.Message}");
            }
        }

        private void CheckAndStartElevationService()
        {
            const string elevationServiceName = " .\\JWLimited.ElevationService.exe";

            // Check if the Elevation Service is running
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(elevationServiceName));

            if (processes.Length == 0)
            {
                StartService(elevationServiceName);

                while (processes.Length == 0)
                {
                    Thread.Sleep(1000);
                    processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(elevationServiceName));
                }

                Console.WriteLine($"Elevation Service started successfully.");
            }
            else
            {
                Console.WriteLine($"Elevation Service is already running.");
            }
        }

        private void StartService(string serviceName)
        {
            IntPtr hSCManager = IntPtr.Zero;
            IntPtr hService = IntPtr.Zero;

            try
            {
                hSCManager = OpenSCManager(null, null, (uint)ServiceControlManagerAccessRights.SC_MANAGER_ALL_ACCESS);

                if (hSCManager == IntPtr.Zero)
                {
                    throw new ApplicationException("Failed to open Service Control Manager.");
                }

                hService = OpenService(hSCManager, serviceName, (uint)ServiceAccessRights.SERVICE_ALL_ACCESS);

                if (hService == IntPtr.Zero)
                {
                    throw new ApplicationException("Failed to open Elevation Service.");
                }

                if (!StartService(hService, 0, null))
                {
                    throw new ApplicationException("Failed to start Elevation Service.");
                }
            }
            finally
            {
                if (hService != IntPtr.Zero)
                {
                    CloseServiceHandle(hService);
                }

                if (hSCManager != IntPtr.Zero)
                {
                    CloseServiceHandle(hSCManager);
                }
            }
        }

        private int WaitForTaskToStart(string executableName)
        {
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(executableName));

            while (processes.Length == 0)
            {
                Thread.Sleep(1000);
                processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(executableName));
            }

            // Assuming the first process in the array is the one we're waiting for
            return processes[0].Id;
        }

    }

    // Enums and structs for Windows Service Control Manager
    [Flags]
    public enum ServiceControlManagerAccessRights
    {
        SC_MANAGER_CONNECT = 0x0001,
        SC_MANAGER_CREATE_SERVICE = 0x0002,
        SC_MANAGER_ENUMERATE_SERVICE = 0x0004,
        SC_MANAGER_LOCK = 0x0008,
        SC_MANAGER_QUERY_LOCK_STATUS = 0x0010,
        SC_MANAGER_MODIFY_BOOT_CONFIG = 0x0020,
        SC_MANAGER_ALL_ACCESS = 0xF003F
    }

    [Flags]
    public enum ServiceAccessRights
    {
        SERVICE_ALL_ACCESS = 0xF01FF,
        SERVICE_CHANGE_CONFIG = 0x0002,
        SERVICE_ENUMERATE_DEPENDENTS = 0x0008,
        SERVICE_INTERROGATE = 0x0080,
        SERVICE_PAUSE_CONTINUE = 0x0040,
        SERVICE_QUERY_CONFIG = 0x0001,
        SERVICE_QUERY_STATUS = 0x0004,
        SERVICE_START = 0x0010,
        SERVICE_STOP = 0x0020,
        SERVICE_USER_DEFINED_CONTROL = 0x0100
    }
}

