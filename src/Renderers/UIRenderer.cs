using System;
using DungeonCrawler.Managers.Graphics;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Levels;

// 45 by 23 For maps in the Template

namespace DungeonCrawler.Managers.UI;

/// <summary>A class that handles the rendering of UI elements.</summary>
class UIRenderer {

    LevelManager levelManager;

    string pathToUITemplate = "";

    char[][] uiTemplate;

    /// <summary>Creates a new UIRenderer.</summary>
    /// <param name="pathToUITemplate">The path to the UI template file.</param>
    public UIRenderer(string pathToUITemplate, LevelManager levelManager) {
        this.pathToUITemplate = pathToUITemplate;
        uiTemplate = File.ReadAllLines(pathToUITemplate).Select(line => line.ToCharArray()).ToArray();
        this.levelManager = levelManager;
    }

    /// <summary>Renders the UI.</summary>
    public async void RenderUI() {

        for (int x = 0; x < uiTemplate.Length; x++) {
            for (int y = 0; y < uiTemplate[x].Length; y++) {
                if (x >= 7 && x <= 29 && y == 15) {
                    await ColorRenderer.DecodeAndRenderCharAsync(uiTemplate[x][y]);
                    levelManager.RenderLine();
                    continue;
                }
                Console.Write(uiTemplate[x][y]); // Just write these for now, I'll implement the Color Renderer later :p
            }
            Console.WriteLine();
        }

    }

}