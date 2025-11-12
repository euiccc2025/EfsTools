using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("writeNvItem", HelpText = "Write single NV item from a file or a string payload.")]
    internal class WriteNvItemOptions
    {
        [Option('i', "itemId", Required = true, HelpText = "NV item ID.")]
        public ushort ItemId { get; set; }

        [Option('c', "inComputerFilePath", Required = false, HelpText = "Input computer file path.", SetName = "file")]
        public string InComputerFilePath { get; set; }
        
        [Option('p', "payload", Required = false, HelpText = "Input payload string (for Hex or Dec formats).", SetName = "payload")]
        public string Payload { get; set; }

        [Option('f', "format", Required = false, Default = NvItemFormat.Raw, HelpText = "Input format (Raw, Hex, Dec). Default is Raw. 'Raw' format is not supported for payload input.")]
        public NvItemFormat Format { get; set; }
    }
}