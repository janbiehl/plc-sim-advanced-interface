using CommandLine;

namespace ConsoleApp;

public class CommandLineOptions
{
    [Option('v', "verbose", Required = false, 
        HelpText = "Set debug output to verbose")]
    public bool Verbose { get; set; } = false;

    // TODO: This one should be required
    [Option('i', "instance", Required = false,
        HelpText = "The instance name which is used for the plc inside PlcSimAdvanced")]
    public string PlcInstanceName { get; set; } = string.Empty;
}