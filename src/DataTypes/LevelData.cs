using System;
using DungeonCrawler.DataTypes;
using DungeonCrawler.Managers.Graphics;
using DungeonCrawler.Managers.UI;
using Newtonsoft.Json;

namespace DungeonCrawler.DataTypes;

class LevelData {

    [JsonProperty("pathToTextFile")]
    public string pathToTextFile { get; set; }

    [JsonProperty("upFile")]
    public string upFile { get; set; }

    [JsonProperty("downFile")]
    public string downFile { get; set; }

    [JsonProperty("leftFile")]
    public string leftFile { get; set; }

    [JsonProperty("rightFile")]
    public string rightFile { get; set; }
    
}

