using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class RobloxResolve
{
    [JsonProperty("robloxID")]
    public string? RobloxID { get; private set; }
    
    [JsonProperty("resolved")]
    public ResolvedRoblox? Resolved { get; private set; }
}