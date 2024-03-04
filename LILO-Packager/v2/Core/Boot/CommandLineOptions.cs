using CommandLine;

namespace LILO_Packager.v2.Core.Boot;
public class CommandLineOptions
{
    [Value(0, MetaName = "FilePath", Required = true, HelpText = "Path to the file to open.")]
    public string FilePath { get; set; }

    [Option('v', "view", Required = false, Default = ViewMode.Encrypted, HelpText = "File view mode (Encrypted, DebugSessionLog, TextFile).")]
    public ViewMode ViewMode { get; set; }
}


