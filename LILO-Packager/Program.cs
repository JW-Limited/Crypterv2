/*
   ------------------------------------------------------------------------------
   Copyright (c) 2024 JW Limited. All rights reserved.

   Project: CrypterV2
   Company: JW Limited  
   Author: Joey West (CEO)

   This software is proprietary to JW Limited and constitutes valuable 
   intellectual property. It is entrusted solely to employees named above
   and may not be disclosed, copied, reproduced, transmitted, or used in 
   any manner outside of the scope of its license without prior written
   authorization from JW Limited.

   ------------------------------------------------------------------------------
*/


using System.Diagnostics;
using LILO_Packager.v2;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Core.Boot;
using LILO_Packager.v2.Core.BugBarrier;
using LILO_Packager.v2.Core.Interfaces;
using JWLimited.Licensing.Core;
using LILO_Packager.v2.Forms;

namespace LILO_Packager
{
    public static partial class Program
    {
        public static NotifyIcon noty;
        public static JWLimited.ApiCollection.Registry.Manager RegistryManager = JWLimited.ApiCollection.Registry.Manager.Create("Crypterv2",(e) =>
        {
            ConsoleManager.Instance().WriteLineWithColor(e.Message, ConsoleColor.DarkRed);
        });
        public static DependencyInjectionContainer InstanceCacheContainer = new DependencyInjectionContainer();
        public static string Version = "v0.22.0-beta";
        public static string ProductVersion = "Professional Developer Edition";
        public static string LibraryName = "JWLimited.Crypter.Collections";
        public static int BuildNumber = 20030;
        public static string CloudVersion = "0.9.5-preview";
        private static IBootManager _bootManager;
        public static LicenseManager LicMng;
        public static TaskManager TaskMng;
        public static JWLimited.AuthAgent _AuthAgent;

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            BugBarrier.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            _AuthAgent = JWLimited.AuthAgent.CreateAgent(new JWLimited.Application()
            {
                Executable = Application.ExecutablePath,
                Name = "Crypterv2",
                RealName = LibraryName,
                ProjectLink = "https://github.com/JW-Limited/Crypterv2"
            });

            InstanceCacheContainer.Register<IBootManager>(() => new BootManager());
            _bootManager = InstanceCacheContainer.Resolve<IBootManager>();

            if(config.Default.aggrementAccepted &&
               !config.Default.installedBindings 
               || config.Default.debugInstallHelper)
            {
                config.Default.installedBindings = true;
                config.Default.Save();

                Task.Run(() =>
                {
                    try
                    {
                        Process.Start(@$"{EnviromentVariables.ApplicationDirectory}auth-in\Elevate.exe", $"{EnviromentVariables.ApplicationDirectory}InstallHelper.exe --cp=" + Application.ExecutablePath);
                        ConsoleManager.Instance().WriteLineWithColor("Started InstallHelper the Application is closing now meanwhile the Helper is doing his thing.", ConsoleColor.DarkGreen);
                    }
                    catch (Exception ex)
                    {
                        ConsoleManager.Instance().WriteLineWithColor(ex.Message);
                    }
                });
            }
            

            InstanceCacheContainer.Register<ILILOConsoleManager>(() => ConsoleManager.Instance());

            //ConsoleManager.Instance().ShowConsoleWindow();
        }

        [STAThread]
        public static void Main(string[] args)
        {
            InitializeApplication();

            //RunAgrrementv2();

            if (config.Default.aggrementAccepted)
            {
                try
                {
                    LicMng = LicenseManager.Initialize(_AuthAgent);
                    if(LicMng.CheckLicx<CrypterLicense,CrypterLicenseTrail>(EnviromentVariables.ApplicationDirectory, new CrypterLicense(), new CrypterLicenseTrail()) == 1)
                    {
                        RegistryManager.SetKey("EvaluationState", "0x1093");

                        JWLimited.ApiCollection.Registry.Manager.Trees TreeManager = new JWLimited.ApiCollection.Registry.Manager.Trees("Crypterv2");
                        TreeManager.CreateNode(new JWLimited.ApiCollection.Registry.RegistryNode()
                        {
                            Children = new Dictionary<string, JWLimited.Contracts.API.IChangableNode>()
                            {
                                { "",
                                    new JWLimited.ApiCollection.Registry.RegistryNode()
                                    {
                                        Name = "CurrentState",
                                        Value = "1x0",
                                    } 
                                }
                            },
                            Name = "License",
                            Value = "CurrentState"
                        });


                        if(RegistryManager.GetKey("ShwDbgCns") == "1")
                        {
                            ConsoleManager.Instance().ShowConsoleWindow();
                        }
                        else
                        {
                            RegistryManager.SetKey("ShwDbgCns","0x0");
                        }

                        if (args.Length > 0)
                        {
                            _bootManager.Run(args);
                        }
                        else
                        {
                            try
                            {
                                if (IsApplicationAlreadyRunning())
                                {
                                    if (LifeManagement.IsAlive())
                                    {
                                        BringRunningInstanceToFront();
                                        return;
                                    }

                                    var procID = Process.GetCurrentProcess().Id;

                                    foreach(var procC in Process.GetProcessesByName("crypterv2"))
                                    {
                                        if (procC.Id == procID) continue;

                                        procC.Kill();
                                    }
                                }

                                var processes = Process.GetProcessesByName("JWLimited.ElevationService");

                                foreach (var process in processes)
                                {
                                    process.Kill();
                                }

                                var proc = new Process()
                                {
                                    StartInfo = new ProcessStartInfo()
                                    {
                                        FileName = ".\\JWLimited.ElevationService.exe",
                                        CreateNoWindow = true,
                                        RedirectStandardOutput = true,
                                        RedirectStandardError = true,
                                        WindowStyle = ProcessWindowStyle.Hidden,
                                        Verb = "arun"
                                    },
                                   
                                };

                                proc.Start();

                                proc.OutputDataReceived += (s, e) =>
                                {
                                    ConsoleManager.Instance().WriteLineWithColor("[JWLimited.ElevationService]" + e.Data, ConsoleColor.DarkGray);
                                };

                                proc.BeginOutputReadLine();

                                

                                TaskMng = new TaskManager();
                                var prefix = new string[]
                                {
                                    "--cp=" + Application.ExecutablePath
                                };
                                //TaskMng.StartTaskAsAdmin(@$"{EnviromentVariables.ApplicationDirectory}InstallHelper.exe",prefix);

                                RunMainUI();
                            }
                            catch (Exception ex)
                            {
                                System.Windows.MessageBox.Show("An Error Accoured: " + ex.Message, "Error - RunMainUi");
                                ConsoleManager.Instance().WriteLineWithColor("An Error Acourred: " + ex.Message, ConsoleColor.Red);
                            }
                        }
                    }
                    else
                    {
                        var licUI = new uiLicenseDetails(null);
                        licUI.Text = "License Expired.";
                        licUI.StartPosition = FormStartPosition.CenterScreen;
                        licUI.ShowIcon = false;
                        licUI.MinimizeBox = false;
                        licUI.MaximizeBox = false;
                        licUI.TopMost = true;
                        Application.Run(licUI);
                    }

                    
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error - BootManager", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error, 
                                    MessageBoxDefaultButton.Button2, 
                                    MessageBoxOptions.ServiceNotification);
                }
            }
            else
            {
                RunAgrrementv2();
            }
            
        }

        private static bool IsApplicationAlreadyRunning()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(currentProcess.ProcessName);

            var otherProcesses = processes.Where(p => p.Id != currentProcess.Id);

            return otherProcesses.Any();
        }

        private static void BringRunningInstanceToFront()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(currentProcess.ProcessName);

            foreach (var process in processes)
            {
                if (process.Id != currentProcess.Id)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    if (hWnd != IntPtr.Zero)
                    {
                        NativeMethods.SetForegroundWindow(hWnd);
                        NativeMethods.ShowWindow(hWnd, NativeMethods.SW_RESTORE);
                    }
                }
            }

            Environment.Exit(0);
        }

        private static async void RunMainUI()
        {
            if(RegistryManager.GetKey("OpenedSetupOnce") != "1")
            {
                RunAgrrementv2();
            }

            MainHost.Instance().AutoScaleMode = AutoScaleMode.Font;
            //Application.AddMessageFilter(new AdvancedMessageFilter(MainHost.Instance()));
            Application.Run(MainHost.Instance());
        }

        //private static void RunAgrrement()
        //{
        //    Application.Run(v2.Forms.uiAgrement.Instance());
        //}

        private static void RunAgrrementv2()
        {
            RegistryManager.SetKey("OpenedSetupOnce", "1");

            Application.Run(new uiSetup());
        }
    }
}

