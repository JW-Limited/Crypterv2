using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Shared;
using System.Text;
using CommandLine;
using LILO_Packager.v2.Core.Debug.Types;
using LILO_Packager.v2.Shared.Types;
using LILO_Packager.v2.Plugins.ThirdParty;
using System.Diagnostics;
using LILO_Packager.v2.Core.Interfaces;

namespace LILO_Packager.v2.Core.Boot
{

    public class BootManager : IBootManager
    {
        public void Run(string[] args)
        {
            var parser = new Parser(config =>
            {
                config.AutoHelp = true;
                config.AutoVersion = true;
            });

            var result = parser.ParseArguments<CommandLineOptions>(args);

            result.WithParsed(options =>
                {
                    if (!File.Exists(options.FilePath))
                    {
                        HandleFileNotFound(options.FilePath);
                        return;
                    }

                    if (options.FilePath.EndsWith(".lsf"))
                    {
                        HandleEncryptedFile(options.FilePath);
                    }
                    else if (options.FilePath.EndsWith(".cryptex"))
                    {
                        HandlePluginFile(options.FilePath);
                    }
                    else if (options.FilePath.EndsWith(".dbgsl"))
                    {
                        HandleDebugSessionLogFile(options.FilePath);
                    }
                    else
                    {
                        HandleUnknownFile(options.FilePath);
                    }
                })
                .WithNotParsed(errors =>
                {
                    HandleArgumentParsingErrors(errors, result);
                });
        }

        private void HandleFileNotFound(string filePath)
        {
            ConsoleManager.Instance().ShowConsoleWindow();
            ConsoleManager.Instance().WriteLineWithColor($"File not found: {filePath}", ConsoleColor.Red);
            Console.ReadKey();
        }

        private void HandleEncryptedFile(string filePath)
        {
            ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Opening EncryptionPopupDialog", ConsoleColor.DarkGreen);

            EncryptedFile file = new EncryptedFile(filePath);
            var decryptionUI = uiArgumentStart.Instance(file);
            Application.Run(decryptionUI);
        }

        private void HandlePluginFile(string filePath)
        {
            //ConsoleManager.Instance().ShowConsoleWindow();
            ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Opening EncryptionPopupDialog", ConsoleColor.DarkGreen);

            Application.Run(PluginInstaller.Instance(LILO_Packager.v2.Plugins.ThirdParty.Types.Plugin.Create(filePath)));
        }

        private void HandleDebugSessionLogFile(string filePath)
        {
            ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Opening DebugSessionLogViewer", ConsoleColor.DarkGreen);

            var log = LogFile.Parse(new FileInfo(filePath).Name);

            var debugSession = new DebugSession()
            {
                FileName = log.Name,
                Content = File.ReadAllText(filePath),
                CreatedAt = log.DateTime,
                SessionName = $"{log.Guid}",
            };

            var debugUI = new uiDebugSessionLogViewer(debugSession);
            Application.Run(debugUI);
        }

        private void HandleUnknownFile(string filePath)
        {
            ConsoleManager.Instance().WriteLineWithColor($"Unknown file type: {filePath}", ConsoleColor.Yellow);
            ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Opening DecryptionPopupDialog", ConsoleColor.DarkGreen);

            DecryptedFile file = new DecryptedFile(filePath);
            var decryptionUI = uiArgumentStart_Encrypt.Instance(file);
            Application.Run(decryptionUI);
        }

        private void HandleUnknownViewMode(string filePath)
        {
            ConsoleManager.Instance().WriteLineWithColor($"Unknown view mode for file: {filePath}", ConsoleColor.Yellow);
        }

        private void HandleArgumentParsingErrors(IEnumerable<Error> errors, ParserResult<CommandLineOptions> result)
        {
            var helpText = new StringBuilder();
            helpText.AppendLine("Usage: YourApp.exe [options] <FilePath>");
            helpText.AppendLine("Options:");
            helpText.AppendLine("-v, --view    File view mode (Encrypted, DebugSessionLog, TextFile).");

            foreach (var error in errors)
            {
                if (error.StopsProcessing)
                {
                    helpText.AppendLine("Error: " + error.Tag);
                    break;
                }
            }
            ConsoleManager.Instance().ShowConsoleWindow();
            ConsoleManager.Instance().WriteLineWithColor(helpText.ToString(), ConsoleColor.Red);
            Console.ReadKey();
        }

        public static void ExecuteBatchScript(int waitTimeInSeconds, string applicationPath)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                process.StandardInput.WriteLine($"@echo off");
                process.StandardInput.WriteLine($"setlocal");
                process.StandardInput.WriteLine($":: Define the number of seconds to wait");
                process.StandardInput.WriteLine($"set \"wait_seconds={waitTimeInSeconds}\"");
                process.StandardInput.WriteLine($":: Display a countdown message");
                process.StandardInput.WriteLine($"for /l %%i in (!wait_seconds! -1 1) do (");
                process.StandardInput.WriteLine($"cls");
                process.StandardInput.WriteLine($"echo Waiting for %%i seconds...");
                process.StandardInput.WriteLine($"timeout /t 1 /nobreak >nul");
                process.StandardInput.WriteLine($")");
                process.StandardInput.WriteLine($":: Start the application");
                process.StandardInput.WriteLine($"start \"\" \"{applicationPath}\"");
                process.StandardInput.WriteLine($"endlocal");
                process.StandardInput.WriteLine($"exit");

                process.WaitForExit();
                process.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }


}


