using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using DungeonCrawler.Managers;
using DungeonCrawler.Managers.Graphics;
using DungeonCrawler.Managers.UI;
using DungeonCrawler.DataTypes;




class TestProject {

    public static void Main(string[] args) {

        // Console Setup
        Console.CursorVisible = false;
        Console.WindowHeight = 30;
        Console.WindowWidth = 120;

        Console.Clear();

        const string pathToUITemplate = "src\\UITemplate.txt";

        UIRenderer uiRenderer = new UIRenderer(pathToUITemplate);
        uiRenderer.RenderUI();
        Console.ReadKey(true);

    }

}
