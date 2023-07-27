using System;
using System.IO;
using Newtonsoft.Json;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Graphics;

namespace DungeonCrawler.Managers.UI;

static class DialogueManager {

    const int dialogueBoxWidth = 45;

    public static void RunDialogue(NPC npc) {

        string[] dialogue = npc.GetDialogue();
        Console.WriteLine("\r");

        // Do this for now, as I don't have a UI system in place yet where the dialogue would be displayed.
        foreach (string line in dialogue) {
            
            Console.SetCursorPosition(16, 23);
            if (line.Length >= dialogueBoxWidth) {
                Draw.String(ConsoleColor.White, ConsoleColor.Black, line.Substring(0, dialogueBoxWidth), 50);
                Console.SetCursorPosition(16, 24);
                Draw.String(ConsoleColor.White, ConsoleColor.Black, line.Substring(dialogueBoxWidth, line.Length - dialogueBoxWidth), 50);
            } else {
                Draw.String(ConsoleColor.White, ConsoleColor.Black, line, 50);
            }
            Console.ReadKey(true);
            DeleteDialogue();

        }

    }

    private static void DeleteDialogue() {

        Console.SetCursorPosition(16, 23);
        Console.Write(new string(' ', dialogueBoxWidth));
        Console.SetCursorPosition(16, 24);
        Console.Write(new string(' ', dialogueBoxWidth));
        Console.SetCursorPosition(16, 25);
        Console.Write(new string(' ', dialogueBoxWidth));
        Console.SetCursorPosition(16, 23);

    }

}