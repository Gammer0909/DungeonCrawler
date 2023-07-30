using System;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Graphics;
using DungeonCrawler.Managers.UI;

// 45 by 23 For maps in the Template

namespace DungeonCrawler.Managers.Levels;

class LevelManager {

    char[][] levelData;
    public const int levelWidth = 22;
    public const int levelHeight = 44;
    int levelLine = 0;

    public LevelManager(LevelData levelData) {
        this.levelData = new char[levelWidth][];
        LoadLevel(levelData);
    }

    public void LoadLevel(string pathToLevel) {
            
            string[] levelData = File.ReadAllLines(pathToLevel);
            this.levelData = levelData.Select(line => line.ToCharArray()).ToArray();
            levelLine = 0;
    }

    public void LoadLevel(LevelData levelData) {
        string pathToLevel = levelData.pathToTextFile;
        LoadLevel(pathToLevel);
    }

    public async Task RenderLevel() {

        for (int x = 0; x < levelData.Length; x++) {
            for (int y = 0; y < levelData[x].Length; y++) {
                await ColorRenderer.DecodeAndRenderCharAsync(levelData[x][y]); // Just write these for now, I'll implement the Color Renderer later :p
            }
            Console.WriteLine();
        }

    }

    public void RenderLine() {

        string line = new string(levelData[levelLine]);
        foreach (char c in line) {
            ColorRenderer.DecodeAndRenderChar(c);
        }
        if (levelLine < levelData.Length - 1) {
            levelLine++;
        }
    }

    public void ResetLevel() {
        levelLine = 0;
    }

}