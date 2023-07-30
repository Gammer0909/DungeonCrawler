using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using DungeonCrawler.Managers;
using DungeonCrawler.Managers.Graphics;
using DungeonCrawler.Managers.UI;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Levels;
using DungeonCrawler.Debug;


namespace DungeonCrawler.Main;

class DungeonCrawlerGame : Game {

    ConsoleKeyInfo lastKeyPress;

    public static void Main(string[] args) {

        var game = new DungeonCrawlerGame("Assets\\Scenes\\TestScene\\Levels\\TestLevel\\TestLevelData.json");
        game.Start();
        
    }

    public DungeonCrawlerGame(string levelJsonPath) : base() {
        try {
            this.level = JsonConvert.DeserializeObject<LevelData>(File.ReadAllText(levelJsonPath));
        } catch (Exception e) {
            Logger.Crash("Crashed on an exception.\nBefore submitting an issue, please try the following:\nReinstalling the game,\nVerifying all the files are there by using the check at the main menu.\n", 5);
        }

        try {
            this.levelRenderer = new LevelManager(this.level);
        } catch (Exception e) {
            Logger.Crash("Crashed on an exception.\nBefore submitting an issue, please try the following:\nReinstalling the game,\nVerifying all the files are there by using the check at the main menu.\n", e.Message, 5);
        }

        try {
            this.ui = new UIRenderer("Assets//Templates//UITemplate.txt", this.levelRenderer);
        } catch(Exception e) {
            Logger.Crash("Crashed on an exception.\nBefore submitting an issue, please try the following:\nReinstalling the game,\nVerifying all the files are there by using the check at the main menu.\n", e.Message, 5);
        }
    }
    


    // Safely end the game, like saving the data and closing the window
    public override void End()
    {
        throw new NotImplementedException();    
    }

    // Render the updated code
    public override void Render()
    {
        levelRenderer.ResetLevel();
        ResetConsole();
        // Render the UI/Level
        ui.RenderUI();


    }

    private void ResetConsole() {

        Console.Clear();
        Console.ResetColor();
        Console.Clear();

    }

    // Start the game
    public override void Start()
    {
        // Any other initialization code here
        Update();
        // End method

    }

    private async Task<ConsoleKeyInfo> GetKeyAsync() {
        return await Task.Run(() => Console.ReadKey(true));
    }

    // Run update calculations here
    public async override void Update()
    {
        while (true) {
            
            Render();
            lastKeyPress = Console.ReadKey(true);
            // Other logic :p
            if (lastKeyPress.Key == ConsoleKey.Escape) {
                End();
            }
        }

    }
}
