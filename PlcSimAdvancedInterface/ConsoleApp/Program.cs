using CommandLine;
using ConsoleApp;

// Create a object for the command line options, with default values
CommandLineOptions commandLineOptions = new ();

try
{
    // Parse the command line args
    Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed(options =>
    {
        // store it for later use
        commandLineOptions = options;

        if (commandLineOptions.Verbose)
            Console.WriteLine("Verbose output logging is enabled");
    });
}
catch
{
    // Exit when parsing has failed
    Console.WriteLine("There was an error parsing the command line arguments");
    return -1;
}

return 0;