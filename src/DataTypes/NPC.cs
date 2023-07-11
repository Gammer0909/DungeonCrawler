using System;
using DungeonCrawler.UI;


namespace DungeonCrawler.DataTypes;

// TODO: Add NPC class
class NPC {

    private string pathtoFile = "";
    private string[] dialogue = new string[0];

    /// <param>pathtoJSON: The path to the JSON file containing the NPC's dialogue.</param>
    /// <summary>Creates a new NPC object.</summary>
    public NPC(string pathToFile) {

        this.pathtoFile = pathToFile;

        if (!System.IO.File.Exists(pathtoFile)) {
            throw new System.IO.FileNotFoundException("File not found: " + pathtoFile);
        }

        LoadDialogue();
    
    }

    private void LoadDialogue() {

        dialogue = File.ReadAllLines(pathtoFile);


    }


    /// <summary>Returns the NPC's dialogue.</summary>
    public string[] GetDialogue() {
        return dialogue;
    }

    public void PrintDialogue() {

        foreach (string line in dialogue) {
            Console.WriteLine(line);
        }

    }
    
}