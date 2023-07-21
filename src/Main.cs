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




class TestProject {

    public static void Main(string[] args) {

        // Console Setup
        Console.CursorVisible = false;
        Console.Clear();
        LevelData levelData = JsonConvert.DeserializeObject<LevelData>(File.ReadAllText("Assets\\Scenes\\TestScene\\Levels\\TestLevel\\TestLevelData.json"));
        

        const string pathToUITemplate = "Assets\\Templates\\UITemplate.txt";
        LevelManager levelManager = new LevelManager(levelData);
        UIRenderer uiRenderer = new UIRenderer(pathToUITemplate, levelManager);
        // Render the level using LevelManager.RenderLine() 
        for (int i = 0; i < 45; i++) {
            levelManager.RenderLine();
            Console.WriteLine();
        }

        // uiRenderer.RenderUI();
        Console.ReadKey(true);

    }

}
