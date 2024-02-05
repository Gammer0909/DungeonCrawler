using System;
using Spectre.Console.Cli;

namespace Gammer0909.DungeonCrawler.Settings;

/// <summary>
/// Base settings for the application.
/// </summary>
public class BaseSettings : CommandSettings {

    [CommandOption("-v|--verbose")]
    public bool? Verbose { get; set; }

    [CommandOption("-l|--should-log")]
    public bool? Log { get; set; }

    [CommandOption("-a|--force-ascii")]
    public bool? ForceAscii { get; set; }

    [CommandOption("-c|--no-color")]
    public bool? Color { get; set; }

}
