using LILO_Packager.v2.Core.Debug;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;

namespace LILO_Packager.v2.Core.Boot
{
    public class BootManager
    {
        public BootManager() 
        {

        }

        public void AnalyzeArguments(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (!File.Exists(args[i])) return;

                if (args[i].EndsWith(".lsf"))
                {
                    ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Now Open EncyrptionPopupDialog", ConsoleColor.DarkGreen);

                    EncryptedFile file = new EncryptedFile(args[i]);
                    var decrypt = uiArgumentStart.Instance(file);
                    Application.Run(decrypt);
                }
                else if (args[i].EndsWith(".dbgsl"))
                {
                    if (!File.Exists(args[i])) return;

                    // TODO: The .dbgsl File is in the Moment only a text file i want to 
                    //       make it a json or xml file for better handling faster loading and 
                    //       no need for the big parser i set up
                    
                    var log = LogFile.Parse(new FileInfo(args[i]).Name);

                    var debugSession = new DebugSession()
                    {
                        FileName = log.Name,
                        Content = File.ReadAllText(args[i]),
                        CreatedAt = log.DateTime,
                        SessionName = $"{log.Guid}",
                    };

                    var debugUI = new uiDebugSessionLogViewer(debugSession);

                    ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Now Open DebugSessionLogViewer", ConsoleColor.DarkGreen);

                    Application.Run(debugUI);
                }
                else
                {
                    ConsoleManager.Instance().WriteLineWithColor("Started with Arguments: Now Open DecyrptionPopupDialog", ConsoleColor.DarkGreen);

                    DecryptedFile file = new DecryptedFile(args[i]);
                    var encrypt = uiArgumentStart_Encrypt.Instance(file);
                    Application.Run(encrypt);
                }
            }
        }
    }
}
