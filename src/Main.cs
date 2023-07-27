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
        Console.Title = "Dungeon Crawler";
        Console.Clear();
        LevelData levelData = JsonConvert.DeserializeObject<LevelData>(File.ReadAllText("Assets\\Scenes\\TestScene\\Levels\\TestLevel\\TestLevelData.json"));
        

        const string pathToUITemplate = "Assets\\Templates\\UITemplate.txt";
        LevelManager levelManager = new LevelManager(levelData);
        UIRenderer uiRenderer = new UIRenderer(pathToUITemplate, levelManager);

        uiRenderer.RenderUI();
        Console.ReadKey(true);

        DialogueManager.RunDialogue(new NPC("Assets\\Scenes\\TestScene\\Levels\\TestLevel\\NPCs\\TestNPC\\Dialogue.txt"));
        Console.ReadKey(true);

    }

}
