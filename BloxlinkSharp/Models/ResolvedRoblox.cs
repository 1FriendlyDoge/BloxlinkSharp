using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class ResolvedRoblox
{
    [JsonProperty("discord")]
    public Discord? Discord { get; private set; }

    [JsonProperty("roblox")]
    public Roblox? Roblox { get; private set; }
}