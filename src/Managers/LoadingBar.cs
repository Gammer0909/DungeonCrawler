using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DungeonCrawler.UI.Loading;

class LoadingBar {

    int currentIteration;
    int totalIterations;
    int barLength;

    public LoadingBar(int totalIterations, int barLength) {
        this.totalIterations = totalIterations;
        this.barLength = barLength;
    }
    
    public void IterateLoadingBar() {

        double percentage = (double) currentIteration / totalIterations * 100;

        double barFill = (double) currentIteration / totalIterations * barLength;

        
        Console.Write("\r<");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(new String('#', Convert.ToInt32(barFill)));
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(new String('=', Convert.ToInt32(barLength - barFill)));
        Console.Write("> " + Convert.ToInt32(percentage) + "%");
        

        currentIteration++;


    }

}