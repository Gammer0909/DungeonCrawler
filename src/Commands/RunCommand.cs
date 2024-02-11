using System;
using Gammer0909.DungeonCrawler.Settings;
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
        }


        AnsiConsole.Clear();
        return 0;

    }


    public static string GetSaveFile() {

        var saveFileSelect = new SelectionPrompt<string>()
            .Title("Save Files")
            .PageSize(10);

        // Get the saves, they'll be in Assets/Saves
        if (!Path.Exists("Assets/Saves")) {

            // If the directory doesn't exist, create it, then create a new save
            Directory.CreateDirectory("Assets/Saves");
            File.WriteAllText("Assets/Saves/save1.json", "{}");
            return "Assets/Saves/save1.json";

        }

        var saves = Directory.GetFiles("Assets/Saves");

        if (saves.Length == 0) {

            // If there are no saves, create a new one
            File.WriteAllText("Assets/Saves/save1.json", "{}");
            return "Assets/Saves/save1.json";

        }

        // Before we throw the names into the prompt, let's format them

        // We want to get them all in a string[]
        var saveNames = new string[saves.Length];

        for (var i = 0; i < saves.Length; i++) {

            var save = saves[i];
            var saveName = save.Replace("Assets/Saves/", "").Replace(".json", "");
            saveNames[i] = saveName;

        }

        // Now we can add them to the prompt
        saveFileSelect.AddChoices(saveNames);
        

        return AnsiConsole.Prompt(saveFileSelect);



    }

}