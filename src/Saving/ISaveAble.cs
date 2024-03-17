using System;

namespace Gammer0909.DungeonCrawler.Saving;

/// <summary>
/// Interface for classes that can be saved.
/// </summary>
public interface ISaveAble {

    public string SerializeData();

}