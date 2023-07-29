using System;
using DungeonCrawler.Managers;
using DungeonCrawler.Managers.Graphics;
using DungeonCrawler.Managers.UI;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Levels;

abstract class Game {
    
    protected UIRenderer ui;
    protected LevelData level;
    protected LevelManager levelRenderer;

    public abstract void Start();
    public abstract void Update();
    public abstract void Render();
    public abstract void End();

    public Game() {

        // Initialize Your code here

    }

}