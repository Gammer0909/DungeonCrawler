using System;
using System.Collections.Generic;

namespace DungeonCrawler.Managers.Graphics;

/// <summary>Class for drawing to the console</summary>
static class Draw {


    // <param>fg: Foreground color</param>
    // <param>bg: Background color</param>
    // <param>txt: Text to be printed</param>
    // <summary>Prints a pixel with specified colors</summary>
    public static void Pixel(ConsoleColor fg, ConsoleColor bg, char txt) {

        Console.ForegroundColor = fg;
        Console.BackgroundColor = bg;
        Console.Write(txt);
        Console.ResetColor();

    }

    /// <param>fg: Foreground color</param>
    /// <param>txt: Text to be printed</param>
    /// <summary>Prints a pixel with default background color</summary>
    public static void Pixel(ConsoleColor fg, char txt) {

        Console.ForegroundColor = fg;
        Console.Write(txt);
        Console.ResetColor();

    }

    /// <param>txt: Text to be printed</param>
    /// <summary>Prints a pixel with default colors</summary>
    public static void Pixel(char txt) {

        Console.Write(txt);

    }

    /// <param>fg: Foreground color</param>
    /// <param>bg: Background color</param>
    /// <param>txt: Text to be printed</param>
    /// <param>length: Length of the line</param>
    /// <summary>Prints a line of specified text and length</summary>
    public static void Line(ConsoleColor fg, ConsoleColor bg, char txt, int length) {

        for (int i = 0; i < length; i++) {

            Pixel(fg, bg, txt);

        }

    }

    /// <param>fg: Foreground color</param>
    /// <param>txt: Text to be printed</param>
    /// <param>length: Length of the line</param>
    /// <summary>Prints a line of specified text and length</summary>
    public static void Line(ConsoleColor fg, char txt, int length) {

        for (int i = 0; i < length; i++) {

            Pixel(fg, txt);

        }

    }


    /// <param>txt: Text to be printed</param>
    /// <param>length: Length of the line</param>
    /// <summary>Prints a line of specified text and length</summary>
    public static void Line(char txt, int length) {

        for (int i = 0; i < length; i++) {

            Pixel(txt);

        }

    }

    /// <param>fg: Foreground color</param>
    /// <param>bg: Background color</param>
    /// <summary>Prints a column of specified text and length</summary>
    public static void Column(ConsoleColor fg, ConsoleColor bg, char txt, int length) {

        for (int i = 0; i < length; i++) {

            Pixel(fg, bg, txt);
            Console.WriteLine();

        }

    }

    /// <param>fg: Foreground color</param>
    /// <param>txt: Text to be printed</param>
    /// <param>length: Length of the line</param>
    /// <summary>Prints a column of specified text and length</summary>
    public static void Column(ConsoleColor fg, char txt, int length) {

        for (int i = 0; i < length; i++) {

            Pixel(fg, txt);
            Console.WriteLine();

        }

    }

    /// <param>txt: Text to be printed</param>
    /// <param>length: Length of the line</param>
    /// <summary>Prints a column of specified text and length</summary>
    public static void Column(char txt, int length) {

        for (int i = 0; i < length; i++) {

            Pixel(txt);
            Console.WriteLine();

        }

    }

    /// <param>fg: Foreground color</param>
    /// <param>bg: Background color</param>
    /// <param>txt: Text to be printed</param>
    /// <param>width: Width of the square</param>
    /// <param>height: Height of the square</param>
    /// <summary>Prints a square of specified text and length</summary>
    public static void Square(ConsoleColor fg, ConsoleColor bg, char txt, int width, int height) {

        for (int i = 0; i < height; i++) {

            Line(fg, bg, txt, width);
            Console.WriteLine();

        }

    }

    /// <param>fg: Foreground color</param>
    /// <param>txt: Text to be printed</param>
    /// <param>width: Width of the square</param>
    /// <param>height: Height of the square</param>
    /// <summary>Prints a square of specified text and length</summary>
    public static void Square(ConsoleColor fg, char txt, int width, int height) {

        for (int i = 0; i < height; i++) {

            Line(fg, txt, width);
            Console.WriteLine();

        }

    }

    /// <param>txt: Text to be printed</param>
    /// <param>width: Width of the square</param>
    /// <param>height: Height of the square</param>
    /// <summary>Prints a square of specified text and length</summary>
    public static void Square(char txt, int width, int height) {

        for (int i = 0; i < height; i++) {

            Line(txt, width);
            Console.WriteLine();

        }

    }

    /// <param>fg: Foreground color</param>
    /// <param>bg: Background color</param>
    /// <param>txt: Text to be printed</param>
    /// <param>delay: Delay between each character</param>
    /// <summary>Prints a string with specified colors and delay</summary>
    public static void String(ConsoleColor fg, ConsoleColor bg, string txt, int delay) {

        for (int i = 0; i < txt.Length; i++) {

            Pixel(fg, bg, txt[i]);
            System.Threading.Thread.Sleep(delay);

        }


    }

}