using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("readNvItem", HelpText = "Read single NV item.")]
    internal class ReadNvItemOptions
    {
        [Option('i', "itemId", Required = true, HelpText = "NV item ID.")]
        public ushort ItemId { get; set; }

        [Option('o', "outComputerFilePath", Required = false, HelpText = "Output computer file path. If not specified, output will be sent to the console.")]
        public string OutComputerFilePath { get; set; }

        [Option('f', "format", Required = false, Default = NvItemFormat.Raw, HelpText = "Output format (Raw, Hex, Dec). Default is Raw. 'Raw' format is not supported for console output and will default to 'Hex'.")]
        public NvItemFormat Format { get; set; }
    }
}