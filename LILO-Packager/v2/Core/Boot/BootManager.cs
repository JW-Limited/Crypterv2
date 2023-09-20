using LILO_Packager.v2.Core.Debug;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Commands;
using CommandLine;
using Windows.Globalization;
using CommandLine.Text;

namespace LILO_Packager.v2.Core.Boot
{

    public class BootManager
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

        private void HandleParsedOptions(CommandLineOptions options)
        {
            if (!File.Exists(options.FilePath))
            {
                HandleFileNotFound(options.FilePath);
                return;
            }

            if (options.ViewMode == ViewMode.Encrypted)
            {
                HandleEncryptedFile(options.FilePath);
            }
            else if (options.ViewMode == ViewMode.DebugSessionLog)
            {
                HandleDebugSessionLogFile(options.FilePath);
            }
            else
            {
                HandleUnknownViewMode(options.FilePath);
            }
        }

        private void HandleFileNotFound(string filePath)
        {
            ConsoleManager.Instance().WriteLineWithColor($"File not found: {filePath}", ConsoleColor.Red);
        }

        private void HandleEncryptedFile(string filePath)
        {
            ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Opening EncryptionPopupDialog", ConsoleColor.DarkGreen);

            EncryptedFile file = new EncryptedFile(filePath);
            var decryptionUI = uiArgumentStart.Instance(file);
            Application.Run(decryptionUI);
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

            ConsoleManager.Instance().WriteLineWithColor(helpText.ToString(), ConsoleColor.Red);
        }
    }
}


