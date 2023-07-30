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



    public static void Main(string[] args) {

        try {
            var game = new DungeonCrawlerGame("Assets//Scenes//TestScene//TestLeveData.json");
        } catch (FileLoadException fle) {
            Logger.Crash("Crashed on an exception.\nBefore submitting an issue, please try the following:\nReinstalling the game,\nVerifying all the files are there by using the check at the main menu.\n", fle.Message, 64);
        }

    }

    public DungeonCrawlerGame(string levelJsonPath) : base() {

        try {
            this.level = JsonConvert.DeserializeObject<LevelData>(File.ReadAllText(levelJsonPath));
        } catch (FileNotFoundException e) {
            throw new FileLoadException("Failed to load file " + levelJsonPath);
        }

    }

    public override void End()
    {
        throw new NotImplementedException();
    }

    public override void Render()
    {
        throw new NotImplementedException();
    }

    public override void Start()
    {
        


    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}
