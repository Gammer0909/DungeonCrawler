using System;
using System.IO;

namespace DungeonCrawler.Managers.UI.Animations;

class AnimationManager {


    private string[] animationFrame;
    private int currentFrame;
    private int totalFrames;

    /// <param>firstFile: The first file in the animation sequence.</param>
    /// <param>totalFrames: The total number of frames in the animation sequence.</param>
    /// <summary>Creates a new AnimationManager object.</summary>
    public AnimationManager(string firstFile, int totalFrames) {
        
        if (!File.Exists(firstFile)) {
            throw new FileNotFoundException("File not found: " + firstFile);
        }

        animationFrame = File.ReadAllLines(firstFile);

        this.totalFrames = totalFrames;
        currentFrame = 0;

    }

    /// <param>nextFile: The next file in the animation sequence.</param>
    /// <summary>Loads the next frame in the animation sequence.</summary>
    public void NextFrame(string nextFile) {


        if (!File.Exists(nextFile)) {
            throw new FileNotFoundException("File not found: " + nextFile);
        }

        animationFrame = File.ReadAllLines(nextFile);

    }

    /// <summary>Runs the current frame in the animation sequence.</summary>
    public void RunFrame() {

        foreach (string line in animationFrame) {
            Console.WriteLine(line);
        }

        currentFrame++;
    }

    /// <summary>Returns the current frame index.</summary>
    public int GetFrameIndex() {
        return currentFrame;
    }

    /// <summary>Returns the total number of frames in the animation sequence.</summary>
    public int GetTotalFrames() {
        return totalFrames;
    }

}