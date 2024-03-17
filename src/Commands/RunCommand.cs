using System;
using Gammer0909.DungeonCrawler.Settings;
using Gammer0909.DungeonCrawler.Saving;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Gammer0909.DungeonCrawler.Commands;

public class RunCommand : Command<RunSettings> {

    public override int Execute(CommandContext context, RunSettings settings) {
        
        AnsiConsole.Clear();

        AnsiConsole.Write(
            new FigletText("Dungeon Crawler")
                .LeftJustified()
                .Color(Color.Red)
        );

        var mainMenuSelect = new SelectionPrompt<string>()
            .Title("Main Menu")
            .PageSize(10)
            .AddChoices(new[] {
                "Save Files",
                "New Game",
                "Exit"
            });

        var choice = AnsiConsole.Prompt(mainMenuSelect);

        if (choice == "Exit") {
            AnsiConsole.Clear();
            return 0;
        } else if (choice == "Save Files") {
            var saveFile = GetSaveFile();
            AnsiConsole.MarkupLine($"[bold]Selected Save File:[/] {saveFile}");
            // TODO: Start the game with the save file
        } else {
            AnsiConsole.MarkupLine("[bold]Starting a new game...[/]");
            NewGame();
        }


        AnsiConsole.Clear();
        return 0;

    }

    private static void NewGame() {



    }


    private static void StartGame(SaveFile saveFile) {



    }


    private static string GetSaveFile() {

        var saveFileSelect = new SelectionPrompt<string>()
            .Title("Save Files")
            .PageSize(10);

        // Get the saves, they'll be in Assets/Saves
        if (!Path.Exists("Assets/Saves")) {

            // If the directory doesn't exist, tell user they need to make a new game, then close the application
            AnsiConsole.MarkupLine("[bold]No save files found. Please start a new game first.[/]\nPress any key to close the application.");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);

        }

        var saves = Directory.GetFiles("Assets/Saves");

        if (saves.Length == 0) {

            // If there are no save files, restart the application before telling user they need to start a new game first
            AnsiConsole.MarkupLine("[bold]No save files found. Please start a new game first.[/]\nPress any key to close the application.");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);

        }

        // Before we throw the names into the prompt, let's format them

        // We want to get them all in a string[]
        var saveNames = new string[saves.Length];

        for (var i = 0; i < saves.Length; i++) {

            var save = saves[i];
            var saveName = save.Replace("Assets/Saves/", "").Replace(".json", ""); // I'll also add in the playtime when I get to that part...
            saveNames[i] = saveName;

        }

        // Now we can add them to the prompt
        saveFileSelect.AddChoices(saveNames);
        

        return AnsiConsole.Prompt(saveFileSelect);



    }

}