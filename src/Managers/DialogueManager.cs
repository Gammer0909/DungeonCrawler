using System;
using System.IO;
using Newtonsoft.Json;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Graphics;

namespace DungeonCrawler.Managers.UI;

static class DialogueManager {

    public static void RunDialogue(NPC npc) {

        string[] dialogue = npc.GetDialogue();

        // Do this for now, as I don't have a UI system in place yet where the dialogue would be displayed.
        foreach (string line in dialogue) {
            Draw.String(ConsoleColor.White, ConsoleColor.Black, line, 50);
            Console.ReadKey(true);
            Console.WriteLine("\r");
        }

    }

}