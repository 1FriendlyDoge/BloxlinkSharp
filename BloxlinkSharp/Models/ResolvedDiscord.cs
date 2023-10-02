using Newtonsoft.Json;

namespace BloxlinkSharp.Models;

public class ResolvedDiscord
{
    [JsonProperty("discord")]
    public Dictionary<string, DiscordUserResolve> Discord { get; private set; } = new();
}