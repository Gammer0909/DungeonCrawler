using System;
using DungeonCrawler.Managers.Graphics;

class ColorRenderer {

    // Normal Rendering methods in case other people need them; however I don't.

    /// <param name="color">The color to render the text in.</param>
    /// <param name="text">The text to render.</param>
    /// <summary>Renders text in a specified color.</summary>
    public static void RenderColor(ConsoleColor color, string text) {

        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();

    }

    /// <param name="fgColor">The color to render the text in.</param>
    /// <param name="bgColor">The background color to render the text in.</param>
    /// <param name="text">The text to render.</param>
    /// <summary>Renders text in a specified color.</summary>
    public static void RenderColor(ConsoleColor fgColor, ConsoleColor bgColor, char text) {

        Console.ForegroundColor = fgColor;
        Console.BackgroundColor = bgColor;
        Console.Write(text);
        Console.ResetColor();

    }

    /// <param name="c">The character to render.</param>
    /// <summary>Renders a character in a specified color.</summary>
    public static async Task DecodeAndRenderCharAsync(char c) => await Task.Run(() => DecodeAndRenderChar(c));

    /// <param name="c">The character to render.</param>
    /// <summary>Renders a character in a specified color.</summary>
    public static void DecodeAndRenderChar(char c) {

        ConsoleColor[] colors = DecodeColor(c);

        Console.ForegroundColor = colors[0];
        Console.BackgroundColor = colors[1];

        Console.Write(c);
        Console.ResetColor();

    }


    private static ConsoleColor[] DecodeColor(char c) {

        switch (c) {

            case '*':
                return new ConsoleColor[] { ConsoleColor.White, ConsoleColor.Black };
            case 'Y':
                return new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.DarkGreen };
            case 'D':
                return new ConsoleColor[] { ConsoleColor.Gray, ConsoleColor.Black };
            case 'K':
                return new ConsoleColor[] { ConsoleColor.Yellow, ConsoleColor.DarkYellow };
            case 'M':
                return new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.DarkRed };
            case 'C':
                return new ConsoleColor[] { ConsoleColor.DarkYellow, ConsoleColor.Yellow };
            case 'P':
                return new ConsoleColor[] { ConsoleColor.DarkMagenta, ConsoleColor.Magenta };
            case '-':
                return new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Gray };
            case ' ':
                return new ConsoleColor[] { ConsoleColor.Gray, ConsoleColor.Gray };
            case '┌':
            case '┬':
            case '┤':
            case '┐':
            case '└':
            case '┘':
            case '─':
            case '┴':
            case '├':
            case '│':
                return new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.White };
            default:
                return new ConsoleColor[] { ConsoleColor.White, ConsoleColor.Black };
        }

    }

}