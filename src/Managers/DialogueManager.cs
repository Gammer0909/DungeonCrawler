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
            DeleteDialogue();
            if (line.Length >= dialogueBoxWidth) {
                int dialougeLine = 1;
                for (int i = 0; i < line.Length; i++) {

                    if (i % dialogueBoxWidth == 0 && i != 0) {
                        dialougeLine++;
                        Console.SetCursorPosition(16, 23 + dialougeLine);
                    }
                    Draw.String(ConsoleColor.White, ConsoleColor.Black, line[i].ToString(), 50);

                }

            }
            Draw.String(ConsoleColor.White, ConsoleColor.Black, line, 50);
            Console.ReadKey(true);
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