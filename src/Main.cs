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


namespace DungeonCrawler.Main;

class DungeonCrawlerGame : Game {



    public static void Main(string[] args) {

       var game = new DungeonCrawlerGame();
       game.Start();

    }

    public DungeonCrawlerGame(string ) : base() {

        this.level = new LevelData();

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
