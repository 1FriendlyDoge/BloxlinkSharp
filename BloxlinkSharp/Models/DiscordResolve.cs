using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class DiscordResolve
{
    [JsonProperty("discordIDs")]
    public List<string> DiscordIDs { get; private set; } = new();

    [JsonProperty("resolved")]
    public ResolvedDiscord? Resolved { get; private set; }
}