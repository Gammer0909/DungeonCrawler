using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DungeonCrawler.Debug;

static class Logger {

    /// <param name="message">The message to write in the crash log</param>
    /// <param name="errorCode">The error code that goes with the crash log</param>
    /// <summary>Writes a log for a game crash message, inferring the crash message from the error code</summary>
    public static void Crash(string[] message, int errorCode) {

        using (StreamWriter sw = new StreamWriter("Logs//crash-log-errorcode-" + errorCode + ".log", false, Encoding.ASCII)) {

            sw.Write(message);
            sw.WriteLine();
            string crashMessage;
            switch (errorCode) {

                case 1:
                    crashMessage = "Unknown error. Please submit a ticket at the GitHub (https://github.com/Gammer0909/DungeonCrawler)";
                    break;
                case 5:
                    crashMessage = "Important Assets/Files missing, please install a fresh copy or submit a ticket (https://github.com/Gammer0909/DungeonCrawler)";
                    break;
                // TODO: add new cases as I need them...
                default:
                    crashMessage = "Error";
                    break;

                    

            }
            sw.Write("Error code: " + errorCode + "\nCrash Message: " + crashMessage);

        }

        Environment.Exit(errorCode);

    }

        /// <param name="message">The message to write in the crash log</param>
        /// <param name="crashMessage">The message that the game crashed with, such as an exeption message</param>
        /// <param name="errorCode">The error code that goes with the crash log</param>
        /// <summary>Writes a log for a game crash message</summary>
        public static void Crash(string[] message, string crashMessage,  int errorCode) {

        using (StreamWriter sw = new StreamWriter("Logs//crash-log-errorcode-" + errorCode + ".log", false, Encoding.ASCII)) {

            sw.Write(message);
            sw.WriteLine();
            sw.Write("Error code: " + errorCode + "\nCrash Message: " + crashMessage);

        }

        Environment.Exit(errorCode);

    }

        /// <param name="message">The message to write in the crash log</param>
        /// <param name="crashMessage">The message that the game crashed with, such as an exeption message</param>
        /// <param name="errorCode">The error code that goes with the crash log</param>
        /// <summary>Writes a log for a game crash message</summary>
        public static void Crash(string message, string crashMessage,  int errorCode) {

        using (StreamWriter sw = new StreamWriter("Logs//crash-log-errorcode-" + errorCode + ".log", false, Encoding.ASCII)) {

            sw.Write(message);
            sw.WriteLine();
            sw.Write("Error code: " + errorCode + "\nCrash Message: " + crashMessage);

        }

        Environment.Exit(errorCode);

    }

        /// <param name="message">The message to write in the crash log</param>
        /// <param name="crashMessage">The message that the game crashed with, such as an exeption message</param>
        /// <param name="errorCode">The error code that goes with the crash log</param>
        /// <summary>Writes a log for a game crash message</summary>
        public static void Crash(string message, int errorCode) {

        using (StreamWriter sw = new StreamWriter("Logs//crash-log-errorcode-" + errorCode + ".log", false, Encoding.ASCII)) {

            sw.Write(message);
            sw.WriteLine();
            string crashMessage;
            switch (errorCode) {

                case 1:
                    crashMessage = "Unknown error. Please submit a ticket at the GitHub (https://github.com/Gammer0909/DungeonCrawler)";
                    break;
                case 5:
                    crashMessage = "Important Assets/Files missing, please install a fresh copy or submit a ticket (https://github.com/Gammer0909/DungeonCrawler)";
                    break;
                // TODO: add new cases as I need them...
                default:
                    crashMessage = "Error";
                    break;

                    

            }
            sw.Write("Error code: " + errorCode + "/nCrash message: " + crashMessage);

        }

        Environment.Exit(errorCode);

    }

    public static void Warning(string message, string filePath, bool exists) {

        if (exists) {

            // Write to the existing path
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.ASCII)) {

                sw.Write(message);

            }

        } else {

            // Create the file and write to it
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.ASCII)) {

                sw.Write(message);

            }

        }

    }

}