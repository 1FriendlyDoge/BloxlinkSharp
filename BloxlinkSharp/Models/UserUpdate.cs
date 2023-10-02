using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class UserUpdate
{
    [JsonProperty("addedRoles")]
    public List<string> AddedRoles { get; private set; } = new();
    
    [JsonProperty("removedRoles")]
    public List<string> RemovedRoles { get; private set; } = new();
    
    [JsonProperty("nickname")]
    public string? Nickname { get; private set; }
}