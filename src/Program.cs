using System;
using Spectre.Console.Cli;

namespace Gammer0909.DungeonCrawler;

public class Program {

    public static void Main(string[] args) {

        var application = new CommandApp();
        application.Configure(config => {
            config.AddCommand<Commands.RunCommand>("run")
                .WithDescription("Run the game.");
        });
    
        application.Run(args);

    }

}