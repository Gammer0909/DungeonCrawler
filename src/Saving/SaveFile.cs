using System;
using System.Collections.Generic;

namespace Gammer0909.DungeonCrawler.Saving;

/// <summary>The class representation of a save file.</summary>
public class SaveFile {
    
    private int hourCount;
    private int minuteCount;

    private List<ISaveAble> saveData;
    private string saveFilePath;

    /// <summary>Creates a new save file.</summary>
    /// <param name="hourCount">The hour count of the save file.</param>
    /// <param name="minuteCount">The minute count of the save file.</param>
    /// <param name="saveData">The save data of the save file.</param>
    public SaveFile(int hourCount, int minuteCount, string path, List<ISaveAble> saveData) {
        this.hourCount = hourCount;
        this.minuteCount = minuteCount;
        this.saveFilePath = path;
        this.saveData = saveData;
    }

    /// <summary>
    /// Creates a new (empty) save file.
    /// </summary>
    public SaveFile(string path) {

        this.hourCount = 0;
        this.minuteCount = 0;
        this.saveFilePath = path;
        this.saveData = new List<ISaveAble>();

    }

    /// <summary>Gets the hour count of the save file.</summary>
    /// <returns>The hour count of the save file.</returns>
    public int GetHourCount() {
        return this.hourCount;
    }

    /// <summary>Gets the minute count of the save file.</summary>
    /// <returns>The minute count of the save file.</returns>
    public int GetMinuteCount() {
        return this.minuteCount;
    }

    public void SerializeData() {

        List<string> savedata = new List<string>();

        // This is really hacky but it's ok, basically we're gonna get each line, and then shove it into a JSON file.
        foreach (ISaveAble saveAble in this.saveData) {
            savedata.Add(saveAble.SerializeData());
        }

        // Now we're gonna write the data to a file.
        // Using streams, its easier that way
        using (StreamWriter? writer = new StreamWriter(this.saveFilePath)) {

            writer.WriteLine("{");
            

        }

    }

}